namespace MyWindowsLiveWriterPlugin
{
    partial class SettingForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.chkEscapeCode = new System.Windows.Forms.CheckBox();
            this.labelFont = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.txtFrontCode = new System.Windows.Forms.TextBox();
            this.textBackCode = new System.Windows.Forms.TextBox();
            this.btnRestoreDefault = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.theLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(259, 211);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 29);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkEscapeCode
            // 
            this.chkEscapeCode.AutoSize = true;
            this.chkEscapeCode.Location = new System.Drawing.Point(127, 94);
            this.chkEscapeCode.Name = "chkEscapeCode";
            this.chkEscapeCode.Size = new System.Drawing.Size(216, 16);
            this.chkEscapeCode.TabIndex = 1;
            this.chkEscapeCode.Text = "Escape Content to HTML(Optional)";
            this.chkEscapeCode.UseVisualStyleBackColor = true;
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(48, 12);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(71, 12);
            this.labelFont.TabIndex = 2;
            this.labelFont.Text = "Pre-Content";
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Location = new System.Drawing.Point(44, 125);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(77, 12);
            this.labelBack.TabIndex = 4;
            this.labelBack.Text = "Post-Content";
            // 
            // txtFrontCode
            // 
            this.txtFrontCode.Location = new System.Drawing.Point(125, 12);
            this.txtFrontCode.Multiline = true;
            this.txtFrontCode.Name = "txtFrontCode";
            this.txtFrontCode.Size = new System.Drawing.Size(247, 64);
            this.txtFrontCode.TabIndex = 5;
            // 
            // textBackCode
            // 
            this.textBackCode.Location = new System.Drawing.Point(125, 125);
            this.textBackCode.Multiline = true;
            this.textBackCode.Name = "textBackCode";
            this.textBackCode.Size = new System.Drawing.Size(247, 64);
            this.textBackCode.TabIndex = 6;
            // 
            // btnRestoreDefault
            // 
            this.btnRestoreDefault.Location = new System.Drawing.Point(46, 211);
            this.btnRestoreDefault.Name = "btnRestoreDefault";
            this.btnRestoreDefault.Size = new System.Drawing.Size(188, 29);
            this.btnRestoreDefault.TabIndex = 7;
            this.btnRestoreDefault.Text = "Restore to Default Settings";
            this.btnRestoreDefault.UseVisualStyleBackColor = true;
            this.btnRestoreDefault.Click += new System.EventHandler(this.btnRestoreDefault_Click);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(109, 254);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(215, 12);
            this.copyright.TabIndex = 8;
            this.copyright.Text = "Email: wintys@gmail.com  2009-10-05";
            // 
            // theLinkLabel
            // 
            this.theLinkLabel.AutoSize = true;
            this.theLinkLabel.Location = new System.Drawing.Point(123, 275);
            this.theLinkLabel.Name = "theLinkLabel";
            this.theLinkLabel.Size = new System.Drawing.Size(185, 12);
            this.theLinkLabel.TabIndex = 9;
            this.theLinkLabel.TabStop = true;
            this.theLinkLabel.Text = "http://www.blogjava.net/wintys";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 299);
            this.Controls.Add(this.theLinkLabel);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.btnRestoreDefault);
            this.Controls.Add(this.textBackCode);
            this.Controls.Add(this.txtFrontCode);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.chkEscapeCode);
            this.Controls.Add(this.btnOK);
            this.Name = "SettingForm";
            this.Text = "WintyCodeArea Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkEscapeCode;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.TextBox txtFrontCode;
        private System.Windows.Forms.TextBox textBackCode;
        private System.Windows.Forms.Button btnRestoreDefault;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.LinkLabel theLinkLabel;
    }
}