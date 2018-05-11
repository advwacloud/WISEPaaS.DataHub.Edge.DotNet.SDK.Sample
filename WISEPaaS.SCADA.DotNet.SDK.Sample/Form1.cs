using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WISEPaaS.SCADA.DotNet.SDK;
using WISEPaaS.SCADA.DotNet.SDK.Model;

namespace WISEPaaS.SCADA.DotNet.SDK.Sample
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
                    WriteValueCommandMessage wvCmdMsg = ( WriteValueCommandMessage ) e.Message;
                    foreach ( var item in wvCmdMsg.D.Val )
                    {
                        Console.Write( "Tag: {0}, ", item.Key );
                        Console.WriteLine( "Value: {0}", item.Value );
                    }
                    break;
                /*case MessageType.WriteConfig:
                    break;*/
                case MessageType.DataOn:
                    DataOnCommandMessage dataOnMsg = ( DataOnCommandMessage ) e.Message;
                    EdgeData data = prepareData();
                    bool result = _edgeAgent.SendData( data ).Result;
                    break;
                case MessageType.DataOff:
                    DataOffCommandMessage dataOffMsg = ( DataOffCommandMessage ) e.Message;
                    timer1.Enabled = false;
                    break;
                case MessageType.ConfigAck:
                    ConfigAckMessage cfgAckMsg = ( ConfigAckMessage ) e.Message;
                    MessageBox.Show( string.Format( "Upload Config Result: {0}", cfgAckMsg.D.Cfg.ToString() ) );
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
            if ( string.IsNullOrEmpty( txtScadaId.Text ) )
            {
                MessageBox.Show( "SCADA ID can not be null !" );
                return;
            }

            if ( _edgeAgent == null )
            {
                EdgeAgentOptions options = new EdgeAgentOptions()
                {
                    HostName = txtHostName.Text.Trim(),
                    Port = Convert.ToInt32( txtPort.Text.Trim() ),
                    Username = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    ProtocolType = Protocol.TCP,
                    UseSecure = ckbSecure.Checked,
                    AutoReconnect = true,
                    ReconnectInterval = 1000,
                    ScadaId = txtScadaId.Text.Trim(),
                    Heartbeat = 60000   // default is 60 seconds
                };

                _edgeAgent = new EdgeAgent( options );

                _edgeAgent.Connected += _edgeAgent_Connected;
                _edgeAgent.Disconnected += _edgeAgent_Disconnected;
                _edgeAgent.MessageReceived += _edgeAgent_MessageReceived;
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
                EdgeData.Device device = new EdgeData.Device()
                {
                    Id = "Device" + i,
                    TagList = new List<EdgeData.Tag>()
                };

                for ( int j = 1; j <= numTagCount.Value; j++ )
                {
                    EdgeData.Tag aTag = new EdgeData.Tag()
                    {
                        Name = "ATag" + j,
                        Value = Math.Round( random.NextDouble(), 2 )
                    };
                    EdgeData.Tag dTag = new EdgeData.Tag()
                    {
                        Name = "DTag" + j,
                        Value = j % 2
                    };
                    EdgeData.Tag tTag = new EdgeData.Tag()
                    {
                        Name = "TTag" + j,
                        Value = "TEST " + j.ToString()
                    };
                    device.TagList.Add( aTag );
                    device.TagList.Add( dTag );
                    device.TagList.Add( tTag );
                }
                data.DeviceList.Add( device );
            }
            data.Timestamp = DateTime.UtcNow;

            return data;
        }

        private void btnUploadConfig_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
            config.Scada = new EdgeConfig.ScadaConfig()
            {
                Id = txtScadaId.Text.Trim(),
                Name = "TEST_SCADA",
                Description = "For Test"
            };

            config.Scada.DeviceList = new List<EdgeConfig.DeviceConfig>();
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                EdgeConfig.DeviceConfig device = new EdgeConfig.DeviceConfig()
                {
                    Id = "Device" + i,
                    Name = "Device " + i,
                    Type = "Smart Device",
                    Description = "Device " + i,
                };

                device.AnalogTagList = new List<EdgeConfig.AnalogTagConfig>();
                device.DiscreteTagList = new List<EdgeConfig.DiscreteTagConfig>();
                device.TextTagList = new List<EdgeConfig.TextTagConfig>();

                for ( int j = 1; j <= numTagCount.Value; j++ )
                {
                    EdgeConfig.AnalogTagConfig analogTag = new EdgeConfig.AnalogTagConfig()
                    {
                        Name = "ATag" + j,
                        Description = "ATag " + j,
                        ReadOnly = false,
                        ArraySize = 0,
                        AlarmStatus = false,
                        SpanHigh = 1000,
                        SpanLow = 0,
                        EngineerUnit = string.Empty,
                        IntegerDisplayFormat = 4,
                        FractionDisplayFormat = 2,
                        HHPriority = 0,
                        HHAlarmLimit = 0,
                        HighPriority = 0,
                        HighAlarmLimit = 0,
                        LowPriority = 0,
                        LowAlarmLimit = 0,
                        LLPriority = 0,
                        LLAlarmLimit = 0
                    };
                    EdgeConfig.DiscreteTagConfig discreteTag = new EdgeConfig.DiscreteTagConfig()
                    {
                        Name = "DTag" + j,
                        Description = "DTag " + j,
                        ReadOnly = false,
                        ArraySize = 0,
                        AlarmStatus = false,
                        State0 = "0",
                        State1 = "1",
                        State2 = string.Empty,
                        State3 = string.Empty,
                        State4 = string.Empty,
                        State5 = string.Empty,
                        State6 = string.Empty,
                        State7 = string.Empty,
                        State0AlarmPriority = 0,
                        State1AlarmPriority = 0,
                        State2AlarmPriority = 0,
                        State3AlarmPriority = 0,
                        State4AlarmPriority = 0,
                        State5AlarmPriority = 0,
                        State6AlarmPriority = 0,
                        State7AlarmPriority = 0
                    };
                    EdgeConfig.TextTagConfig textTag = new EdgeConfig.TextTagConfig()
                    {
                        Name = "TTag" + j,
                        Description = "TTag " + j,
                        ReadOnly = false,
                        ArraySize = 0,
                        AlarmStatus = false
                    };

                    device.AnalogTagList.Add( analogTag );
                    device.DiscreteTagList.Add( discreteTag );
                    device.TextTagList.Add( textTag );
                }

                config.Scada.DeviceList.Add( device );
            }

            bool result = _edgeAgent.UploadConfig( ActionType.Create, config ).Result;
        }

        private void btnUpdateConfig_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
            config.Scada = new EdgeConfig.ScadaConfig()
            {
                Id = txtScadaId.Text.Trim(),
                Name = "TEST_SCADA",
                Description = "For Test"
            };

            config.Scada.DeviceList = new List<EdgeConfig.DeviceConfig>();
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                EdgeConfig.DeviceConfig device = new EdgeConfig.DeviceConfig()
                {
                    Id = "Device" + i,
                    Description = "Device " + i,
                };

                device.AnalogTagList = new List<EdgeConfig.AnalogTagConfig>();
                device.DiscreteTagList = new List<EdgeConfig.DiscreteTagConfig>();
                device.TextTagList = new List<EdgeConfig.TextTagConfig>();

                for ( int j = 1; j <= numTagCount.Value; j++ )
                {
                    EdgeConfig.AnalogTagConfig analogTag = new EdgeConfig.AnalogTagConfig()
                    {
                        Name = "ATag" + j,
                        Description = "ATag " + j,
                        //ReadOnly = false,
                        ArraySize = 0
                        /*AlarmStatus = false,
                        SpanHigh = 1000,
                        SpanLow = 0,
                        EngineerUnit = string.Empty,
                        IntegerDisplayFormat = 4,
                        FractionDisplayFormat = 2,
                        HHPriority = 0,
                        HHAlarmLimit = 0,
                        HighPriority = 0,
                        HighAlarmLimit = 0,
                        LowPriority = 0,
                        LowAlarmLimit = 0,
                        LLPriority = 0,
                        LLAlarmLimit = 0*/
                    };
                    EdgeConfig.DiscreteTagConfig discreteTag = new EdgeConfig.DiscreteTagConfig()
                    {
                        Name = "DTag" + j,
                        Description = "DTag " + j,
                        /*ReadOnly = false,
                        ArraySize = 0,*/
                        AlarmStatus = true,
                        /*State0 = "0",
                        State1 = "1",
                        State2 = string.Empty,
                        State3 = string.Empty,
                        State4 = string.Empty,
                        State5 = string.Empty,
                        State6 = string.Empty,
                        State7 = string.Empty,
                        State0AlarmPriority = 0,
                        State1AlarmPriority = 0,
                        State2AlarmPriority = 0,
                        State3AlarmPriority = 0,
                        State4AlarmPriority = 0,
                        State5AlarmPriority = 0,
                        State6AlarmPriority = 0,*/
                        State7AlarmPriority = 0
                    };
                    EdgeConfig.TextTagConfig textTag = new EdgeConfig.TextTagConfig()
                    {
                        Name = "TTag" + j,
                        Description = "TTag " + j,
                        ReadOnly = false
                        /*ArraySize = 0,
                        AlarmStatus = false*/
                    };

                    device.AnalogTagList.Add( analogTag );
                    device.DiscreteTagList.Add( discreteTag );
                    device.TextTagList.Add( textTag );
                }

                config.Scada.DeviceList.Add( device );
            }

            bool result = _edgeAgent.UploadConfig( ActionType.Update, config ).Result;
        }

        private void btnDeleteAllConfig_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
            config.Scada = new EdgeConfig.ScadaConfig()
            {
                Id = txtScadaId.Text.Trim()
            };

            bool result = _edgeAgent.UploadConfig( ActionType.Delete, config ).Result;
        }

        private void btnDeleteDevices_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
            config.Scada = new EdgeConfig.ScadaConfig()
            {
                Id = txtScadaId.Text.Trim()
            };

            config.Scada.DeviceList = new List<EdgeConfig.DeviceConfig>();
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                EdgeConfig.DeviceConfig device = new EdgeConfig.DeviceConfig()
                {
                    Id = "Device" + i
                };

                config.Scada.DeviceList.Add( device );
            }

            bool result = _edgeAgent.UploadConfig( ActionType.Delete, config ).Result;
        }

        private void btnDeleteTags_Click( object sender, EventArgs e )
        {
            if ( _edgeAgent == null )
                return;

            EdgeConfig config = new EdgeConfig();
            config.Scada = new EdgeConfig.ScadaConfig()
            {
                Id = txtScadaId.Text.Trim()
            };

            config.Scada.DeviceList = new List<EdgeConfig.DeviceConfig>();
            for ( int i = 1; i <= numDeviceCount.Value; i++ )
            {
                EdgeConfig.DeviceConfig device = new EdgeConfig.DeviceConfig()
                {
                    Id = "Device" + i
                };

                device.AnalogTagList = new List<EdgeConfig.AnalogTagConfig>();
                device.DiscreteTagList = new List<EdgeConfig.DiscreteTagConfig>();
                device.TextTagList = new List<EdgeConfig.TextTagConfig>();
                for ( int j = 1; j <= numTagCount.Value; j++ )
                {
                    EdgeConfig.AnalogTagConfig analogTag = new EdgeConfig.AnalogTagConfig()
                    {
                        Name = "ATag" + j
                    };
                    EdgeConfig.DiscreteTagConfig discreteTag = new EdgeConfig.DiscreteTagConfig()
                    {
                        Name = "DTag" + j
                    };
                    EdgeConfig.TextTagConfig textTag = new EdgeConfig.TextTagConfig()
                    {
                        Name = "TTag" + j
                    };

                    device.AnalogTagList.Add( analogTag );
                    device.DiscreteTagList.Add( discreteTag );
                    device.TextTagList.Add( textTag );
                }

                config.Scada.DeviceList.Add( device );
            }

            bool result = _edgeAgent.UploadConfig( ActionType.Delete, config ).Result;
        }
    }
}
