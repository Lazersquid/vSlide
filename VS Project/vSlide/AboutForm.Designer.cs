namespace vSlide
{
    partial class AboutForm
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
            this.copyrightNoticeLabel = new System.Windows.Forms.Label();
            this.vSlideVersionLabel = new System.Windows.Forms.Label();
            this.vSlideVersionInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // copyrightNoticeLabel
            // 
            this.copyrightNoticeLabel.AutoSize = true;
            this.copyrightNoticeLabel.Location = new System.Drawing.Point(12, 66);
            this.copyrightNoticeLabel.Name = "copyrightNoticeLabel";
            this.copyrightNoticeLabel.Size = new System.Drawing.Size(166, 26);
            this.copyrightNoticeLabel.TabIndex = 66;
            this.copyrightNoticeLabel.Text = "Copyright © 2016 Lukas Schwarz\r\nAll rights reserved";
            // 
            // vSlideVersionLabel
            // 
            this.vSlideVersionLabel.AutoSize = true;
            this.vSlideVersionLabel.Location = new System.Drawing.Point(95, 9);
            this.vSlideVersionLabel.Name = "vSlideVersionLabel";
            this.vSlideVersionLabel.Size = new System.Drawing.Size(22, 13);
            this.vSlideVersionLabel.TabIndex = 68;
            this.vSlideVersionLabel.Text = "1.1";
            // 
            // vSlideVersionInfoLabel
            // 
            this.vSlideVersionInfoLabel.AutoSize = true;
            this.vSlideVersionInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.vSlideVersionInfoLabel.Name = "vSlideVersionInfoLabel";
            this.vSlideVersionInfoLabel.Size = new System.Drawing.Size(77, 13);
            this.vSlideVersionInfoLabel.TabIndex = 67;
            this.vSlideVersionInfoLabel.Text = "vSlide Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Created with/for vJoy Version 2.1.6";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 101);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vSlideVersionLabel);
            this.Controls.Add(this.vSlideVersionInfoLabel);
            this.Controls.Add(this.copyrightNoticeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "vSlide - About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label copyrightNoticeLabel;
        private System.Windows.Forms.Label vSlideVersionLabel;
        private System.Windows.Forms.Label vSlideVersionInfoLabel;
        private System.Windows.Forms.Label label1;
    }
}