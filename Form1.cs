using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WISEPaaS.DataHub.Edge.DotNet.SDK;
using WISEPaaS.DataHub.Edge.DotNet.SDK.Model;

namespace WISEPaaS.DataHub.Edge.DotNet.SDK.Sample
{
    public partial class Form1 : Form
    {
        private EdgeAgent _edgeAgent;

        public Form1()
        {
            InitializeComponent();
        }

        private void _edgeAgent_MessageReceived( object sender, MessageReceivedEventArgs e )
        {
            switch ( e.Type )
            {
                case MessageType.WriteValue:
                    WriteValueCommand wvcMsg = ( WriteValueCommand ) e.Message;
                    foreach ( var device in wvcMsg.DeviceList )
                    {
                        Console.WriteLine( "DeviceId: {0}", device.Id );
                        foreach ( var tag in device.TagList )
                        {
                            Console.WriteLine( "TagName: {0}, Value: {1}", tag.Name, tag.Value.ToString() );
                            if ( device.Id == "Device1" && tag.Name == "DTag1" )
                            {
                                if ( this.txtDTag1Value.InvokeRequired )
                                {
                                    BeginInvoke( ( MethodInvoker ) delegate()
                                    {
                                        txtDTag1Value.Text = tag.Value.ToString();
                                    } );
                                }
                                // resend the new value to cloud
                                EdgeData data = new EdgeData();
                                EdgeData.Tag dTag = new EdgeData.Tag()
                                {
                                    DeviceId = "Device1",
                                    TagName = "DTag1",
                                    Value = tag.Value
                                };
                                data.TagList.Add( dTag );
                                data.Timestamp = DateTime.Now;
                                bool result = _edgeAgent.SendData( data ).Result;
                            }
                        }
                    }
                    break;
                /*case MessageType.WriteConfig:
                    break;*/
                case MessageType.ConfigAck:
                    ConfigAck cfgAckMsg = ( ConfigAck ) e.Message;
                    MessageBox.Show( string.Format( "Upload Config Result: {0}", cfgAckMsg.Result.ToString() ) );
                    break;
            }
        }

        private void _edgeAgent_Disconnected( object sender, DisconnectedEventArgs e )
        {
            if ( this.lblStatus.InvokeRequired )
            {
                BeginInvoke( ( MethodInvoker ) delegate()
                {
                    lblStatus.Text = "DISCONNECTED";
                    lblStatus.BackColor = Color.Silver;
                } );
            }
        }

        private void _edgeAgent_Connected( object sender, EdgeAgentConnectedEventArgs e )
        {
            if ( this.lblStatus.InvokeRequired )
            {
                BeginInvoke( ( MethodInvoker ) delegate()
                {
                    lblStatus.Text = "CONNECTED";
                    lblStatus.BackColor = Color.Green;
                } );
            }
        }

        private void btnConnect_Click( object sender, EventArgs e )
        {
            if ( string.IsNullOrEmpty( txtNodeId.Text ) )
            {
                MessageBox.Show( "Node ID can not be null !" );
                return;
            }

            if ( _edgeAgent == null )
            {
                EdgeAgentOptions options = new EdgeAgentOptions()
                {
                    DCCS = new DCCSOptions()
                    {
                        CredentialKey = txtDCCSKey.Text.Trim(),
                        APIUrl = txtDCCSAPIUrl.Text.Trim()
                    },

                    AutoReconnect = true,
                    ReconnectInterval = 1000,
                    NodeId = txtNodeId.Text.Trim(),
                    Heartbeat = 60000,   // default is 60 seconds
                    DataRecover = true,
                    UseSecure = ckbSecure.Checked
                };

                _edgeAgent = new EdgeAgent( options );

                _edgeAgent.Connected += _edgeAgent_Connected;
                _edgeAgent.Disconnected += _edgeAgent_Disconnected;
                _edgeAgent.MessageReceived += _edgeAgent_MessageReceived;
            }
            else
            {
                _edgeAgent.Options.NodeId = txtNodeId.Text.Trim();
                _edgeAgent.Options.UseSecure = ckbSecure.Checked;

                _edgeAgent.Options.DCCS = new DCCSOptions()
                {
                    CredentialKey = txtDCCSKey.Text.Trim(),
                    APIUrl = txtDCCSAPIUrl.Text.Trim()
                };
            }

            _edgeAgent.Connect();

        }

        private void btnDisconnect_Click( object sender, EventArgs e )
        {
            timer1.Enabled = false;

            if ( _edgeAgent == null )
                return;

            _edgeAgent.Disconnect();
        }

        private void btnDeviceStatus_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeDeviceStatus deviceStatus = new EdgeDeviceStatus();
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                EdgeDeviceStatus.Device device = new EdgeDeviceStatus.Device()
                {
                    Id = "Device" + i,
                    Status = Status.Online
                };
                deviceStatus.DeviceList.Add( device );
            }
            deviceStatus.Timestamp = DateTime.UtcNow;

            bool result = _edgeAgent.SendDeviceStatus( deviceStatus ).Result;
        }

        private void btnSendData_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            timer1.Enabled = true;
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Reset();
            sw.Start();

            EdgeData data = prepareData();
            bool result = _edgeAgent.SendData( data ).Result;

            sw.Stop();
            Console.WriteLine( sw.Elapsed.TotalMilliseconds.ToString() );

        }


        private EdgeData prepareData()
        {
            Random random = new Random( Guid.NewGuid().GetHashCode() );

            EdgeData data = new EdgeData();
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                for ( int j = 1; j <= numATagCount.Value; j++ )
                {
                    EdgeData.Tag aTag = new EdgeData.Tag()
                    {
                        DeviceId = "Device" + i,
                        TagName = "ATag" + j,
                        Value = random.Next( 100 )
                    };
                    data.TagList.Add( aTag );
                }
                for ( int j = 1; j <= numDTagCount.Value; j++ )
                {
                    EdgeData.Tag dTag = new EdgeData.Tag()
                    {
                        DeviceId = "Device" + i,
                        TagName = "DTag" + j,
                        Value = j % 2
                    };
                    data.TagList.Add( dTag );
                }
                for ( int j = 1; j <= numTTagCount.Value; j++ )
                {
                    EdgeData.Tag tTag = new EdgeData.Tag()
                    {
                        DeviceId = "Device" + i,
                        TagName = "TTag" + j,
                        Value = "TEST " + j.ToString()
                    };
                    data.TagList.Add( tTag );
                }
            }
            data.Timestamp = DateTime.Now;

            return data;
        }

        private void btnUploadConfig_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
          
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                EdgeConfig.DeviceConfig device = new EdgeConfig.DeviceConfig()
                {
                    Id = "Device" + i,
                    Name = "Device " + i,
                    Type = "Smart Device",
                    Description = "Device " + i,
                };
                
                for ( int j = 1; j <= numATagCount.Value; j++ )
                {
                    EdgeConfig.AnalogTagConfig analogTag = new EdgeConfig.AnalogTagConfig()
                    {
                        Name = "ATag" + j,
                        Description = "ATag " + j,
                        ReadOnly = false,
                        ArraySize = 0,
                        SpanHigh = 1000,
                        SpanLow = 0,
                        EngineerUnit = string.Empty,
                        IntegerDisplayFormat = 4,
                        FractionDisplayFormat = 2
                    };
                    device.AnalogTagList.Add( analogTag );
                }

                for ( int j = 1; j <= numDTagCount.Value; j++ )
                {
                    EdgeConfig.DiscreteTagConfig discreteTag = new EdgeConfig.DiscreteTagConfig()
                    {
                        Name = "DTag" + j,
                        Description = "DTag " + j,
                        ReadOnly = false,
                        ArraySize = 0,
                        State0 = "0",
                        State1 = "1",
                        State2 = string.Empty,
                        State3 = string.Empty,
                        State4 = string.Empty,
                        State5 = string.Empty,
                        State6 = string.Empty,
                        State7 = string.Empty
                    };
                    device.DiscreteTagList.Add( discreteTag );
                }

                for ( int j = 1; j <= numTTagCount.Value; j++ )
                {
                    EdgeConfig.TextTagConfig textTag = new EdgeConfig.TextTagConfig()
                    {
                        Name = "TTag" + j,
                        Description = "TTag " + j,
                        ReadOnly = false,
                        ArraySize = 0
                    };

                    device.TextTagList.Add( textTag );
                }

                config.Node.DeviceList.Add( device );
            }

            bool result = _edgeAgent.UploadConfig( ActionType.Create, config ).Result;
        }

        private void btnUpdateConfig_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                EdgeConfig.DeviceConfig device = new EdgeConfig.DeviceConfig()
                {
                    Id = "Device" + i,
                    Description = "Device " + i,
                };

                for ( int j = 1; j <= numATagCount.Value; j++ )
                {
                    EdgeConfig.AnalogTagConfig analogTag = new EdgeConfig.AnalogTagConfig()
                    {
                        Name = "ATag" + j,
                        Description = "ATag " + j,
                        ReadOnly = false,
                        ArraySize = 0,
                        SpanHigh = 1000,
                        SpanLow = 0,
                        EngineerUnit = string.Empty,
                        IntegerDisplayFormat = 4,
                        FractionDisplayFormat = 2
                    };
                    device.AnalogTagList.Add( analogTag );
                }
                for ( int j = 1; j <= numDTagCount.Value; j++ )
                {
                    EdgeConfig.DiscreteTagConfig discreteTag = new EdgeConfig.DiscreteTagConfig()
                    {
                        Name = "DTag" + j,
                        Description = "DTag " + j,
                        ReadOnly = false,
                        ArraySize = 0,
                        State0 = "0",
                        State1 = "1",
                        State2 = string.Empty,
                        State3 = string.Empty,
                        State4 = string.Empty,
                        State5 = string.Empty,
                        State6 = string.Empty,
                        State7 = string.Empty
                    };
                    device.DiscreteTagList.Add( discreteTag );
                }
                for ( int j = 1; j <= numTTagCount.Value; j++ )
                {
                    EdgeConfig.TextTagConfig textTag = new EdgeConfig.TextTagConfig()
                    {
                        Name = "TTag" + j,
                        Description = "TTag " + j,
                        ReadOnly = false,
                        ArraySize = 0
                    };
                    device.TextTagList.Add( textTag );
                }

                config.Node.DeviceList.Add( device );
            }

            bool result = _edgeAgent.UploadConfig( ActionType.Update, config ).Result;
        }

        private void btnDeleteAllConfig_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
            config.Node = new EdgeConfig.NodeConfig();

            bool result = _edgeAgent.UploadConfig( ActionType.Delete, config ).Result;
        }

        private void btnDeleteDevices_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                EdgeConfig.DeviceConfig device = new EdgeConfig.DeviceConfig()
                {
                    Id = "Device" + i
                };

                config.Node.DeviceList.Add( device );
            }

            bool result = _edgeAgent.UploadConfig( ActionType.Delete, config ).Result;
        }

        private void btnDeleteTags_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                EdgeConfig.DeviceConfig device = new EdgeConfig.DeviceConfig()
                {
                    Id = "Device" + i
                };
                for ( int j = 1; j <= numATagCount.Value; j++ )
                {
                    EdgeConfig.AnalogTagConfig analogTag = new EdgeConfig.AnalogTagConfig()
                    {
                        Name = "ATag" + j
                    };
                    device.AnalogTagList.Add( analogTag );
                }
                for ( int j = 1; j <= numDTagCount.Value; j++ )
                {
                    EdgeConfig.DiscreteTagConfig discreteTag = new EdgeConfig.DiscreteTagConfig()
                    {
                        Name = "DTag" + j
                    };
                    device.DiscreteTagList.Add( discreteTag );
                }
                for ( int j = 1; j <= numTTagCount.Value; j++ )
                {
                    EdgeConfig.TextTagConfig textTag = new EdgeConfig.TextTagConfig()
                    {
                        Name = "TTag" + j
                    };
                    device.TextTagList.Add( textTag );
                }

                config.Node.DeviceList.Add( device );
            }

            bool result = _edgeAgent.UploadConfig( ActionType.Delete, config ).Result;
        }
    }
}
