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
            this.lblDeviceCount = new System.Windows.Forms.Label();
            this.btnUploadConfig = new System.Windows.Forms.Button();
            this.txtScadaId = new System.Windows.Forms.TextBox();
            this.lblScadaId = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDCCSKey = new System.Windows.Forms.Label();
            this.txtDCCSKey = new System.Windows.Forms.TextBox();
            this.lblDCCSAPIUrl = new System.Windows.Forms.Label();
            this.txtDCCSAPIUrl = new System.Windows.Forms.TextBox();
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
            this.btnDeleteTags.Location = new System.Drawing.Point(881, 435);
            this.btnDeleteTags.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDeleteTags.Name = "btnDeleteTags";
            this.btnDeleteTags.Size = new System.Drawing.Size(179, 86);
            this.btnDeleteTags.TabIndex = 26;
            this.btnDeleteTags.Text = "Delete Tags";
            this.btnDeleteTags.UseVisualStyleBackColor = true;
            this.btnDeleteTags.Click += new System.EventHandler(this.btnDeleteTags_Click);
            // 
            // btnDeleteDevices
            // 
            this.btnDeleteDevices.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDeleteDevices.Location = new System.Drawing.Point(881, 336);
            this.btnDeleteDevices.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDeleteDevices.Name = "btnDeleteDevices";
            this.btnDeleteDevices.Size = new System.Drawing.Size(179, 86);
            this.btnDeleteDevices.TabIndex = 25;
            this.btnDeleteDevices.Text = "Delete Devices";
            this.btnDeleteDevices.UseVisualStyleBackColor = true;
            this.btnDeleteDevices.Click += new System.EventHandler(this.btnDeleteDevices_Click);
            // 
            // btnDeleteAllConfig
            // 
            this.btnDeleteAllConfig.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDeleteAllConfig.Location = new System.Drawing.Point(881, 238);
            this.btnDeleteAllConfig.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDeleteAllConfig.Name = "btnDeleteAllConfig";
            this.btnDeleteAllConfig.Size = new System.Drawing.Size(179, 86);
            this.btnDeleteAllConfig.TabIndex = 24;
            this.btnDeleteAllConfig.Text = "Delete All Config";
            this.btnDeleteAllConfig.UseVisualStyleBackColor = true;
            this.btnDeleteAllConfig.Click += new System.EventHandler(this.btnDeleteAllConfig_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDisconnect.Location = new System.Drawing.Point(677, 184);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(179, 86);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnUpdateConfig
            // 
            this.btnUpdateConfig.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnUpdateConfig.Location = new System.Drawing.Point(881, 136);
            this.btnUpdateConfig.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(179, 86);
            this.btnUpdateConfig.TabIndex = 23;
            this.btnUpdateConfig.Text = "Update Config";
            this.btnUpdateConfig.UseVisualStyleBackColor = true;
            this.btnUpdateConfig.Click += new System.EventHandler(this.btnUpdateConfig_Click);
            // 
            // ckbSecure
            // 
            this.ckbSecure.AutoSize = true;
            this.ckbSecure.Font = new System.Drawing.Font("新細明體", 12F);
            this.ckbSecure.Location = new System.Drawing.Point(21, 246);
            this.ckbSecure.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ckbSecure.Name = "ckbSecure";
            this.ckbSecure.Size = new System.Drawing.Size(80, 24);
            this.ckbSecure.TabIndex = 22;
            this.ckbSecure.Text = "Secure";
            this.ckbSecure.UseVisualStyleBackColor = true;
            // 
            // btnDeviceStatus
            // 
            this.btnDeviceStatus.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDeviceStatus.Location = new System.Drawing.Point(485, 298);
            this.btnDeviceStatus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDeviceStatus.Name = "btnDeviceStatus";
            this.btnDeviceStatus.Size = new System.Drawing.Size(179, 86);
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
            this.lblStatus.Location = new System.Drawing.Point(591, 34);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(265, 124);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "DISCONNECTED";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numTagCount
            // 
            this.numTagCount.Font = new System.Drawing.Font("新細明體", 12F);
            this.numTagCount.Location = new System.Drawing.Point(249, 340);
            this.numTagCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTagCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTagCount.Name = "numTagCount";
            this.numTagCount.Size = new System.Drawing.Size(160, 31);
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
            this.btnSendData.Location = new System.Drawing.Point(677, 298);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(179, 86);
            this.btnSendData.TabIndex = 21;
            this.btnSendData.Text = "Send Data in Loop";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // lblTagCount
            // 
            this.lblTagCount.AutoSize = true;
            this.lblTagCount.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblTagCount.Location = new System.Drawing.Point(245, 304);
            this.lblTagCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTagCount.Name = "lblTagCount";
            this.lblTagCount.Size = new System.Drawing.Size(87, 20);
            this.lblTagCount.TabIndex = 18;
            this.lblTagCount.Text = "Tag Count";
            // 
            // numDeviceCount
            // 
            this.numDeviceCount.Font = new System.Drawing.Font("新細明體", 12F);
            this.numDeviceCount.Location = new System.Drawing.Point(29, 340);
            this.numDeviceCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDeviceCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDeviceCount.Name = "numDeviceCount";
            this.numDeviceCount.Size = new System.Drawing.Size(160, 31);
            this.numDeviceCount.TabIndex = 17;
            this.numDeviceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDeviceCount
            // 
            this.lblDeviceCount.AutoSize = true;
            this.lblDeviceCount.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblDeviceCount.Location = new System.Drawing.Point(25, 304);
            this.lblDeviceCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDeviceCount.Name = "lblDeviceCount";
            this.lblDeviceCount.Size = new System.Drawing.Size(111, 20);
            this.lblDeviceCount.TabIndex = 16;
            this.lblDeviceCount.Text = "Device Count";
            // 
            // btnUploadConfig
            // 
            this.btnUploadConfig.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnUploadConfig.Location = new System.Drawing.Point(881, 34);
            this.btnUploadConfig.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnUploadConfig.Name = "btnUploadConfig";
            this.btnUploadConfig.Size = new System.Drawing.Size(179, 86);
            this.btnUploadConfig.TabIndex = 20;
            this.btnUploadConfig.Text = "Upload Config";
            this.btnUploadConfig.UseVisualStyleBackColor = true;
            this.btnUploadConfig.Click += new System.EventHandler(this.btnUploadConfig_Click);
            // 
            // txtScadaId
            // 
            this.txtScadaId.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtScadaId.Location = new System.Drawing.Point(18, 64);
            this.txtScadaId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtScadaId.Name = "txtScadaId";
            this.txtScadaId.Size = new System.Drawing.Size(411, 31);
            this.txtScadaId.TabIndex = 15;
            // 
            // lblScadaId
            // 
            this.lblScadaId.AutoSize = true;
            this.lblScadaId.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblScadaId.Location = new System.Drawing.Point(17, 34);
            this.lblScadaId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblScadaId.Name = "lblScadaId";
            this.lblScadaId.Size = new System.Drawing.Size(99, 20);
            this.lblScadaId.TabIndex = 14;
            this.lblScadaId.Text = "SCADA ID";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnConnect.Location = new System.Drawing.Point(485, 184);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(179, 86);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDCCSKey);
            this.groupBox2.Controls.Add(this.txtDCCSKey);
            this.groupBox2.Controls.Add(this.lblDCCSAPIUrl);
            this.groupBox2.Controls.Add(this.txtDCCSAPIUrl);
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
            this.groupBox2.Controls.Add(this.lblDeviceCount);
            this.groupBox2.Controls.Add(this.btnUploadConfig);
            this.groupBox2.Controls.Add(this.txtScadaId);
            this.groupBox2.Controls.Add(this.lblScadaId);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1096, 554);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // lblDCCSKey
            // 
            this.lblDCCSKey.AutoSize = true;
            this.lblDCCSKey.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblDCCSKey.Location = new System.Drawing.Point(15, 111);
            this.lblDCCSKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDCCSKey.Name = "lblDCCSKey";
            this.lblDCCSKey.Size = new System.Drawing.Size(121, 20);
            this.lblDCCSKey.TabIndex = 37;
            this.lblDCCSKey.Text = "Credential Key";
            // 
            // txtDCCSKey
            // 
            this.txtDCCSKey.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtDCCSKey.Location = new System.Drawing.Point(21, 136);
            this.txtDCCSKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtDCCSKey.Name = "txtDCCSKey";
            this.txtDCCSKey.Size = new System.Drawing.Size(408, 31);
            this.txtDCCSKey.TabIndex = 38;
            // 
            // lblDCCSAPIUrl
            // 
            this.lblDCCSAPIUrl.AutoSize = true;
            this.lblDCCSAPIUrl.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblDCCSAPIUrl.Location = new System.Drawing.Point(17, 174);
            this.lblDCCSAPIUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDCCSAPIUrl.Name = "lblDCCSAPIUrl";
            this.lblDCCSAPIUrl.Size = new System.Drawing.Size(69, 20);
            this.lblDCCSAPIUrl.TabIndex = 39;
            this.lblDCCSAPIUrl.Text = "API Url";
            // 
            // txtDCCSAPIUrl
            // 
            this.txtDCCSAPIUrl.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtDCCSAPIUrl.Location = new System.Drawing.Point(20, 198);
            this.txtDCCSAPIUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtDCCSAPIUrl.Name = "txtDCCSAPIUrl";
            this.txtDCCSAPIUrl.Size = new System.Drawing.Size(409, 31);
            this.txtDCCSAPIUrl.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 554);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblDeviceCount;
        private System.Windows.Forms.Button btnUploadConfig;
        private System.Windows.Forms.TextBox txtScadaId;
        private System.Windows.Forms.Label lblScadaId;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDCCSKey;
        private System.Windows.Forms.TextBox txtDCCSKey;
        private System.Windows.Forms.Label lblDCCSAPIUrl;
        private System.Windows.Forms.TextBox txtDCCSAPIUrl;
    }
}

