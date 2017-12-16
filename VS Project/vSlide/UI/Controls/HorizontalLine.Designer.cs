namespace vSlide
{
    partial class HorizontalLine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.seperatorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seperatorLabel
            // 
            this.seperatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.seperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seperatorLabel.Location = new System.Drawing.Point(1, 14);
            this.seperatorLabel.Margin = new System.Windows.Forms.Padding(1);
            this.seperatorLabel.Name = "seperatorLabel";
            this.seperatorLabel.Size = new System.Drawing.Size(202, 2);
            this.seperatorLabel.TabIndex = 41;
            // 
            // HorizontalLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seperatorLabel);
            this.Name = "HorizontalLine";
            this.Size = new System.Drawing.Size(202, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label seperatorLabel;
    }
}
