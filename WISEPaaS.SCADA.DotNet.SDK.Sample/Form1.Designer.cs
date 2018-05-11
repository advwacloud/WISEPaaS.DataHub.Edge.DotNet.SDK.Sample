namespace WISEPaaS.SCADA.DotNet.SDK.Sample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDeleteTags = new System.Windows.Forms.Button();
            this.btnDeleteDevices = new System.Windows.Forms.Button();
            this.btnDeleteAllConfig = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnUpdateConfig = new System.Windows.Forms.Button();
            this.ckbSecure = new System.Windows.Forms.CheckBox();
            this.btnDeviceStatus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.numTagCount = new System.Windows.Forms.NumericUpDown();
            this.btnSendData = new System.Windows.Forms.Button();
            this.lblTagCount = new System.Windows.Forms.Label();
            this.numDeviceCount = new System.Windows.Forms.NumericUpDown();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblDeviceCount = new System.Windows.Forms.Label();
            this.btnUploadConfig = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtScadaId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblScadaId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.lblHostName = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTagCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDeleteTags
            // 
            this.btnDeleteTags.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDeleteTags.Location = new System.Drawing.Point(661, 348);
            this.btnDeleteTags.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteTags.Name = "btnDeleteTags";
            this.btnDeleteTags.Size = new System.Drawing.Size(134, 69);
            this.btnDeleteTags.TabIndex = 26;
            this.btnDeleteTags.Text = "Delete Tags";
            this.btnDeleteTags.UseVisualStyleBackColor = true;
            this.btnDeleteTags.Click += new System.EventHandler(this.btnDeleteTags_Click);
            // 
            // btnDeleteDevices
            // 
            this.btnDeleteDevices.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDeleteDevices.Location = new System.Drawing.Point(661, 269);
            this.btnDeleteDevices.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteDevices.Name = "btnDeleteDevices";
            this.btnDeleteDevices.Size = new System.Drawing.Size(134, 69);
            this.btnDeleteDevices.TabIndex = 25;
            this.btnDeleteDevices.Text = "Delete Devices";
            this.btnDeleteDevices.UseVisualStyleBackColor = true;
            this.btnDeleteDevices.Click += new System.EventHandler(this.btnDeleteDevices_Click);
            // 
            // btnDeleteAllConfig
            // 
            this.btnDeleteAllConfig.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDeleteAllConfig.Location = new System.Drawing.Point(661, 190);
            this.btnDeleteAllConfig.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteAllConfig.Name = "btnDeleteAllConfig";
            this.btnDeleteAllConfig.Size = new System.Drawing.Size(134, 69);
            this.btnDeleteAllConfig.TabIndex = 24;
            this.btnDeleteAllConfig.Text = "Delete All Config";
            this.btnDeleteAllConfig.UseVisualStyleBackColor = true;
            this.btnDeleteAllConfig.Click += new System.EventHandler(this.btnDeleteAllConfig_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDisconnect.Location = new System.Drawing.Point(508, 147);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(134, 69);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnUpdateConfig
            // 
            this.btnUpdateConfig.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnUpdateConfig.Location = new System.Drawing.Point(661, 109);
            this.btnUpdateConfig.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(134, 69);
            this.btnUpdateConfig.TabIndex = 23;
            this.btnUpdateConfig.Text = "Update Config";
            this.btnUpdateConfig.UseVisualStyleBackColor = true;
            this.btnUpdateConfig.Click += new System.EventHandler(this.btnUpdateConfig_Click);
            // 
            // ckbSecure
            // 
            this.ckbSecure.AutoSize = true;
            this.ckbSecure.Font = new System.Drawing.Font("新細明體", 12F);
            this.ckbSecure.Location = new System.Drawing.Point(335, 53);
            this.ckbSecure.Margin = new System.Windows.Forms.Padding(4);
            this.ckbSecure.Name = "ckbSecure";
            this.ckbSecure.Size = new System.Drawing.Size(69, 20);
            this.ckbSecure.TabIndex = 22;
            this.ckbSecure.Text = "Secure";
            this.ckbSecure.UseVisualStyleBackColor = true;
            // 
            // btnDeviceStatus
            // 
            this.btnDeviceStatus.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDeviceStatus.Location = new System.Drawing.Point(364, 238);
            this.btnDeviceStatus.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeviceStatus.Name = "btnDeviceStatus";
            this.btnDeviceStatus.Size = new System.Drawing.Size(134, 69);
            this.btnDeviceStatus.TabIndex = 22;
            this.btnDeviceStatus.Text = "Update Device Status";
            this.btnDeviceStatus.UseVisualStyleBackColor = true;
            this.btnDeviceStatus.Click += new System.EventHandler(this.btnDeviceStatus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Gray;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.Location = new System.Drawing.Point(443, 27);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(199, 100);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "DISCONNECTED";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numTagCount
            // 
            this.numTagCount.Font = new System.Drawing.Font("新細明體", 12F);
            this.numTagCount.Location = new System.Drawing.Point(205, 310);
            this.numTagCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTagCount.Name = "numTagCount";
            this.numTagCount.Size = new System.Drawing.Size(120, 27);
            this.numTagCount.TabIndex = 19;
            this.numTagCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnSendData
            // 
            this.btnSendData.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSendData.Location = new System.Drawing.Point(508, 238);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(134, 69);
            this.btnSendData.TabIndex = 21;
            this.btnSendData.Text = "Send Data in Loop";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // lblTagCount
            // 
            this.lblTagCount.AutoSize = true;
            this.lblTagCount.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblTagCount.Location = new System.Drawing.Point(202, 282);
            this.lblTagCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagCount.Name = "lblTagCount";
            this.lblTagCount.Size = new System.Drawing.Size(74, 16);
            this.lblTagCount.TabIndex = 18;
            this.lblTagCount.Text = "Tag Count";
            // 
            // numDeviceCount
            // 
            this.numDeviceCount.Font = new System.Drawing.Font("新細明體", 12F);
            this.numDeviceCount.Location = new System.Drawing.Point(16, 310);
            this.numDeviceCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDeviceCount.Name = "numDeviceCount";
            this.numDeviceCount.Size = new System.Drawing.Size(120, 27);
            this.numDeviceCount.TabIndex = 17;
            this.numDeviceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtPort.Location = new System.Drawing.Point(226, 51);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(101, 27);
            this.txtPort.TabIndex = 20;
            this.txtPort.Text = "1883";
            // 
            // lblDeviceCount
            // 
            this.lblDeviceCount.AutoSize = true;
            this.lblDeviceCount.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblDeviceCount.Location = new System.Drawing.Point(13, 282);
            this.lblDeviceCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceCount.Name = "lblDeviceCount";
            this.lblDeviceCount.Size = new System.Drawing.Size(94, 16);
            this.lblDeviceCount.TabIndex = 16;
            this.lblDeviceCount.Text = "Device Count";
            // 
            // btnUploadConfig
            // 
            this.btnUploadConfig.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnUploadConfig.Location = new System.Drawing.Point(661, 27);
            this.btnUploadConfig.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadConfig.Name = "btnUploadConfig";
            this.btnUploadConfig.Size = new System.Drawing.Size(134, 69);
            this.btnUploadConfig.TabIndex = 20;
            this.btnUploadConfig.Text = "Upload Config";
            this.btnUploadConfig.UseVisualStyleBackColor = true;
            this.btnUploadConfig.Click += new System.EventHandler(this.btnUploadConfig_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblPort.Location = new System.Drawing.Point(222, 27);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(33, 16);
            this.lblPort.TabIndex = 19;
            this.lblPort.Text = "Port";
            // 
            // txtScadaId
            // 
            this.txtScadaId.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtScadaId.Location = new System.Drawing.Point(16, 238);
            this.txtScadaId.Margin = new System.Windows.Forms.Padding(4);
            this.txtScadaId.Name = "txtScadaId";
            this.txtScadaId.Size = new System.Drawing.Size(309, 27);
            this.txtScadaId.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtPassword.Location = new System.Drawing.Point(18, 171);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(309, 27);
            this.txtPassword.TabIndex = 18;
            // 
            // lblScadaId
            // 
            this.lblScadaId.AutoSize = true;
            this.lblScadaId.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblScadaId.Location = new System.Drawing.Point(15, 214);
            this.lblScadaId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScadaId.Name = "lblScadaId";
            this.lblScadaId.Size = new System.Drawing.Size(79, 16);
            this.lblScadaId.TabIndex = 14;
            this.lblScadaId.Text = "SCADA ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblPassword.Location = new System.Drawing.Point(15, 147);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtUserName.Location = new System.Drawing.Point(19, 109);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(309, 27);
            this.txtUserName.TabIndex = 16;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblUserName.Location = new System.Drawing.Point(13, 84);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 16);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "Username";
            // 
            // txtHostName
            // 
            this.txtHostName.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtHostName.Location = new System.Drawing.Point(18, 51);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(190, 27);
            this.txtHostName.TabIndex = 14;
            this.txtHostName.Text = "127.0.0.1";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblHostName.Location = new System.Drawing.Point(15, 27);
            this.lblHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(74, 16);
            this.lblHostName.TabIndex = 13;
            this.lblHostName.Text = "HostName";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnConnect.Location = new System.Drawing.Point(364, 147);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(134, 69);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteTags);
            this.groupBox2.Controls.Add(this.btnDeleteDevices);
            this.groupBox2.Controls.Add(this.btnDeleteAllConfig);
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Controls.Add(this.btnUpdateConfig);
            this.groupBox2.Controls.Add(this.ckbSecure);
            this.groupBox2.Controls.Add(this.btnDeviceStatus);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.numTagCount);
            this.groupBox2.Controls.Add(this.btnSendData);
            this.groupBox2.Controls.Add(this.lblTagCount);
            this.groupBox2.Controls.Add(this.numDeviceCount);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.lblDeviceCount);
            this.groupBox2.Controls.Add(this.btnUploadConfig);
            this.groupBox2.Controls.Add(this.lblPort);
            this.groupBox2.Controls.Add(this.txtScadaId);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblScadaId);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.txtHostName);
            this.groupBox2.Controls.Add(this.lblHostName);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 443);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 443);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTagCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDeleteTags;
        private System.Windows.Forms.Button btnDeleteDevices;
        private System.Windows.Forms.Button btnDeleteAllConfig;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnUpdateConfig;
        private System.Windows.Forms.CheckBox ckbSecure;
        private System.Windows.Forms.Button btnDeviceStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown numTagCount;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label lblTagCount;
        private System.Windows.Forms.NumericUpDown numDeviceCount;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblDeviceCount;
        private System.Windows.Forms.Button btnUploadConfig;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtScadaId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblScadaId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

