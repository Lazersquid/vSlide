namespace vSlide
{
    partial class DecimalControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.titleLabel);
            this.flowLayoutPanel1.Controls.Add(this.timeNumericUpDown);
            this.flowLayoutPanel1.Controls.Add(this.suffixLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(109, 20);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(45, 13);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Interval:";
            // 
            // timeNumericUpDown
            // 
            this.timeNumericUpDown.BackColor = System.Drawing.Color.Gainsboro;
            this.timeNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.timeNumericUpDown.Location = new System.Drawing.Point(45, 0);
            this.timeNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.timeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timeNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.timeNumericUpDown.Name = "timeNumericUpDown";
            this.timeNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.timeNumericUpDown.TabIndex = 35;
            this.timeNumericUpDown.Tag = "";
            this.timeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // suffixLabel
            // 
            this.suffixLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Location = new System.Drawing.Point(89, 3);
            this.suffixLabel.Margin = new System.Windows.Forms.Padding(0);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(20, 13);
            this.suffixLabel.TabIndex = 36;
            this.suffixLabel.Text = "ms";
            // 
            // DecimalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DecimalControl";
            this.Size = new System.Drawing.Size(109, 20);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.NumericUpDown timeNumericUpDown;
        private System.Windows.Forms.Label suffixLabel;
    }
}
