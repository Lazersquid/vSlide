namespace vSlide
{
    partial class SliderLevelFactory
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.valueTitleLable = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label99 = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Controls.Add(this.titleLabel);
            this.flowLayoutPanel.Controls.Add(this.valueTitleLable);
            this.flowLayoutPanel.Controls.Add(this.numericUpDown);
            this.flowLayoutPanel.Controls.Add(this.label99);
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel.MinimumSize = new System.Drawing.Size(0, 10);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(153, 20);
            this.flowLayoutPanel.TabIndex = 42;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(54, 13);
            this.titleLabel.TabIndex = 39;
            this.titleLabel.Text = "Level 0";
            // 
            // valueTitleLable
            // 
            this.valueTitleLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.valueTitleLable.AutoSize = true;
            this.valueTitleLable.Location = new System.Drawing.Point(62, 3);
            this.valueTitleLable.Margin = new System.Windows.Forms.Padding(0);
            this.valueTitleLable.Name = "valueTitleLable";
            this.valueTitleLable.Size = new System.Drawing.Size(37, 13);
            this.valueTitleLable.TabIndex = 37;
            this.valueTitleLable.Text = "Value:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel.SetFlowBreak(this.numericUpDown, true);
            this.numericUpDown.Location = new System.Drawing.Point(99, 0);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown.TabIndex = 38;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label99
            // 
            this.label99.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(138, 3);
            this.label99.Margin = new System.Windows.Forms.Padding(0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(15, 13);
            this.label99.TabIndex = 41;
            this.label99.Text = "%";
            // 
            // SliderLevelFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "SliderLevelFactory";
            this.Size = new System.Drawing.Size(153, 20);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label valueTitleLable;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label99;
    }
}
