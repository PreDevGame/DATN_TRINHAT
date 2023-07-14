namespace WindowsFormsApp1
{
    partial class frmMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbApplications = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnWorkingScreen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbApplications);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // grbApplications
            // 
            this.grbApplications.Controls.Add(this.btnWorkingScreen);
            this.grbApplications.Controls.Add(this.btnConnect);
            this.grbApplications.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApplications.Location = new System.Drawing.Point(0, 0);
            this.grbApplications.Name = "grbApplications";
            this.grbApplications.Size = new System.Drawing.Size(200, 450);
            this.grbApplications.TabIndex = 0;
            this.grbApplications.TabStop = false;
            this.grbApplications.Text = "Applications";
            this.grbApplications.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Ivory;
            this.btnConnect.Location = new System.Drawing.Point(6, 39);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(188, 56);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connection";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnWorkingScreen
            // 
            this.btnWorkingScreen.BackColor = System.Drawing.Color.Aquamarine;
            this.btnWorkingScreen.Location = new System.Drawing.Point(6, 102);
            this.btnWorkingScreen.Name = "btnWorkingScreen";
            this.btnWorkingScreen.Size = new System.Drawing.Size(188, 57);
            this.btnWorkingScreen.TabIndex = 1;
            this.btnWorkingScreen.Text = "Data";
            this.btnWorkingScreen.UseVisualStyleBackColor = false;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.grbApplications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbApplications;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnWorkingScreen;
    }
}