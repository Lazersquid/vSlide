namespace myFirstVJoyFeeder
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
            this.label2 = new System.Windows.Forms.Label();
            this.vSlideVersionLabel = new System.Windows.Forms.Label();
            this.vSlideVersionInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Created by Lukas Schwarz";
            // 
            // vSlideVersionLabel
            // 
            this.vSlideVersionLabel.AutoSize = true;
            this.vSlideVersionLabel.Location = new System.Drawing.Point(95, 9);
            this.vSlideVersionLabel.Name = "vSlideVersionLabel";
            this.vSlideVersionLabel.Size = new System.Drawing.Size(22, 13);
            this.vSlideVersionLabel.TabIndex = 68;
            this.vSlideVersionLabel.Text = "0.5";
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
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 71);
            this.Controls.Add(this.vSlideVersionLabel);
            this.Controls.Add(this.vSlideVersionInfoLabel);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "vSlide - About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vSlideVersionLabel;
        private System.Windows.Forms.Label vSlideVersionInfoLabel;
    }
}