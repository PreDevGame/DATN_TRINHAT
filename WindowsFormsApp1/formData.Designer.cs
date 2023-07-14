namespace WindowsFormsApp1
{
    partial class formData
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
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txbLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.grbTypeBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grbSize.SuspendLayout();
            this.grbTypeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSize
            // 
            this.grbSize.Controls.Add(this.txbHeight);
            this.grbSize.Controls.Add(this.lblHeight);
            this.grbSize.Controls.Add(this.txbWidth);
            this.grbSize.Controls.Add(this.lblWidth);
            this.grbSize.Controls.Add(this.txbLength);
            this.grbSize.Controls.Add(this.lblLength);
            this.grbSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbSize.Location = new System.Drawing.Point(0, 0);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(346, 476);
            this.grbSize.TabIndex = 0;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size Of Product";
            // 
            // txbHeight
            // 
            this.txbHeight.Location = new System.Drawing.Point(53, 382);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(241, 35);
            this.txbHeight.TabIndex = 5;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(129, 335);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(89, 29);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(53, 244);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(241, 35);
            this.txbWidth.TabIndex = 3;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(129, 197);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(79, 29);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width";
            // 
            // txbLength
            // 
            this.txbLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLength.Location = new System.Drawing.Point(47, 99);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(241, 35);
            this.txbLength.TabIndex = 1;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(123, 52);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(92, 29);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            this.lblLength.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbTypeBox
            // 
            this.grbTypeBox.Controls.Add(this.radioButton2);
            this.grbTypeBox.Controls.Add(this.radioButton1);
            this.grbTypeBox.Controls.Add(this.textBox1);
            this.grbTypeBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTypeBox.Location = new System.Drawing.Point(346, 0);
            this.grbTypeBox.Name = "grbTypeBox";
            this.grbTypeBox.Size = new System.Drawing.Size(309, 476);
            this.grbTypeBox.TabIndex = 6;
            this.grbTypeBox.TabStop = false;
            this.grbTypeBox.Text = "Type Box";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 35);
            this.textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Lime;
            this.radioButton1.Location = new System.Drawing.Point(62, 297);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 33);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Start";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Red;
            this.radioButton2.Location = new System.Drawing.Point(62, 363);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 33);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Stop";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // formData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 476);
            this.Controls.Add(this.grbTypeBox);
            this.Controls.Add(this.grbSize);
            this.Name = "formData";
            this.Text = "formData";
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbTypeBox.ResumeLayout(false);
            this.grbTypeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.GroupBox grbTypeBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}