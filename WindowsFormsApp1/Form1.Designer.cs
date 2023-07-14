namespace WindowsFormsApp1
{
    partial class frmConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbLength = new System.Windows.Forms.RichTextBox();
            this.grbCamera = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.grbPLC = new System.Windows.Forms.GroupBox();
            this.ckbQ1 = new System.Windows.Forms.CheckBox();
            this.ckbQ0 = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblIPConfig = new System.Windows.Forms.Label();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.grbCamera.SuspendLayout();
            this.grbPLC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Lime;
            this.btnStart.Location = new System.Drawing.Point(45, 27);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 59);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbLength
            // 
            this.rtbLength.Location = new System.Drawing.Point(45, 132);
            this.rtbLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbLength.Name = "rtbLength";
            this.rtbLength.Size = new System.Drawing.Size(468, 74);
            this.rtbLength.TabIndex = 1;
            this.rtbLength.Text = "";
            this.rtbLength.TextChanged += new System.EventHandler(this.rtbLength_TextChanged);
            // 
            // grbCamera
            // 
            this.grbCamera.Controls.Add(this.lblData);
            this.grbCamera.Controls.Add(this.btnStart);
            this.grbCamera.Controls.Add(this.rtbLength);
            this.grbCamera.Location = new System.Drawing.Point(15, 13);
            this.grbCamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbCamera.Name = "grbCamera";
            this.grbCamera.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbCamera.Size = new System.Drawing.Size(948, 232);
            this.grbCamera.TabIndex = 2;
            this.grbCamera.TabStop = false;
            this.grbCamera.Text = "Webcam";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(39, 101);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 25);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data";
            // 
            // grbPLC
            // 
            this.grbPLC.Controls.Add(this.ckbQ1);
            this.grbPLC.Controls.Add(this.ckbQ0);
            this.grbPLC.Controls.Add(this.btnConnect);
            this.grbPLC.Controls.Add(this.lblIPConfig);
            this.grbPLC.Controls.Add(this.txbIP);
            this.grbPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPLC.Location = new System.Drawing.Point(16, 267);
            this.grbPLC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbPLC.Name = "grbPLC";
            this.grbPLC.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbPLC.Size = new System.Drawing.Size(947, 319);
            this.grbPLC.TabIndex = 3;
            this.grbPLC.TabStop = false;
            this.grbPLC.Text = "PLC";
            // 
            // ckbQ1
            // 
            this.ckbQ1.AutoSize = true;
            this.ckbQ1.Location = new System.Drawing.Point(50, 198);
            this.ckbQ1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbQ1.Name = "ckbQ1";
            this.ckbQ1.Size = new System.Drawing.Size(85, 29);
            this.ckbQ1.TabIndex = 4;
            this.ckbQ1.Text = "Q0.1";
            this.ckbQ1.UseVisualStyleBackColor = true;
            this.ckbQ1.CheckedChanged += new System.EventHandler(this.ckbQ0_CheckedChanged);
            // 
            // ckbQ0
            // 
            this.ckbQ0.AutoSize = true;
            this.ckbQ0.Location = new System.Drawing.Point(50, 159);
            this.ckbQ0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbQ0.Name = "ckbQ0";
            this.ckbQ0.Size = new System.Drawing.Size(85, 29);
            this.ckbQ0.TabIndex = 3;
            this.ckbQ0.Text = "Q0.0";
            this.ckbQ0.UseVisualStyleBackColor = true;
            this.ckbQ0.CheckedChanged += new System.EventHandler(this.ckbQ0_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Lime;
            this.btnConnect.Location = new System.Drawing.Point(568, 88);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(187, 44);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblIPConfig
            // 
            this.lblIPConfig.AutoSize = true;
            this.lblIPConfig.Location = new System.Drawing.Point(44, 47);
            this.lblIPConfig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPConfig.Name = "lblIPConfig";
            this.lblIPConfig.Size = new System.Drawing.Size(96, 25);
            this.lblIPConfig.TabIndex = 1;
            this.lblIPConfig.Text = "IP config";
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(44, 93);
            this.txbIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(468, 30);
            this.txbIP.TabIndex = 0;
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 603);
            this.Controls.Add(this.grbPLC);
            this.Controls.Add(this.grbCamera);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmConnect";
            this.Text = "Connect Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCamera.ResumeLayout(false);
            this.grbCamera.PerformLayout();
            this.grbPLC.ResumeLayout(false);
            this.grbPLC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbLength;
        private System.Windows.Forms.GroupBox grbCamera;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox grbPLC;
        private System.Windows.Forms.Label lblIPConfig;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.CheckBox ckbQ0;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox ckbQ1;
    }
}

