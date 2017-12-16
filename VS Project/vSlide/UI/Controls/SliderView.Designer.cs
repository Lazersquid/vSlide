namespace vSlide
{
    partial class SliderView
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
            this.sliderTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTrackBar)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliderTrackBar
            // 
            this.sliderTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderTrackBar.LargeChange = 20;
            this.sliderTrackBar.Location = new System.Drawing.Point(1, 14);
            this.sliderTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.sliderTrackBar.Maximum = 100;
            this.sliderTrackBar.MaximumSize = new System.Drawing.Size(100000, 45);
            this.sliderTrackBar.Name = "sliderTrackBar";
            this.sliderTrackBar.Size = new System.Drawing.Size(581, 45);
            this.sliderTrackBar.TabIndex = 28;
            this.sliderTrackBar.ValueChanged += new System.EventHandler(this.sliderTrackBar_ValueChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.sliderTrackBar);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            this.groupBox.Size = new System.Drawing.Size(583, 70);
            this.groupBox.TabIndex = 29;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Slider Value: 0%";
            // 
            // SliderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.MinimumSize = new System.Drawing.Size(0, 70);
            this.Name = "SliderView";
            this.Size = new System.Drawing.Size(583, 70);
            ((System.ComponentModel.ISupportInitialize)(this.sliderTrackBar)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar sliderTrackBar;
        private System.Windows.Forms.GroupBox groupBox;
    }
}
