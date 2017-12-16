namespace vSlide
{
    partial class MainForm
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
            this.feedingButton = new System.Windows.Forms.Button();
            this.vslideInfoBox1 = new VslideInfoBox();
            this.vjoyInfoBox1 = new VjoyInfoBox();
            this.sliderLevelsPanel = new SliderLevelsPanel();
            this.sliderView = new SliderView();
            this.devicePanel = new DevicePanel();
            this.manipulatorPanel = new SliderManipulatorPanel();
            this.SuspendLayout();
            // 
            // feedingButton
            // 
            this.feedingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.feedingButton.Location = new System.Drawing.Point(36, 579);
            this.feedingButton.Name = "feedingButton";
            this.feedingButton.Size = new System.Drawing.Size(118, 23);
            this.feedingButton.TabIndex = 1;
            this.feedingButton.Text = "Start";
            this.feedingButton.UseVisualStyleBackColor = true;
            this.feedingButton.Click += new System.EventHandler(this.feedingButton_Click);
            // 
            // vslideInfoBox1
            // 
            this.vslideInfoBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vslideInfoBox1.Location = new System.Drawing.Point(12, 447);
            this.vslideInfoBox1.Name = "vslideInfoBox1";
            this.vslideInfoBox1.Size = new System.Drawing.Size(165, 56);
            this.vslideInfoBox1.TabIndex = 33;
            // 
            // vjoyInfoBox1
            // 
            this.vjoyInfoBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vjoyInfoBox1.Location = new System.Drawing.Point(12, 368);
            this.vjoyInfoBox1.Margin = new System.Windows.Forms.Padding(0);
            this.vjoyInfoBox1.Name = "vjoyInfoBox1";
            this.vjoyInfoBox1.Size = new System.Drawing.Size(165, 76);
            this.vjoyInfoBox1.TabIndex = 32;
            // 
            // sliderLevelsPanel
            // 
            this.sliderLevelsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderLevelsPanel.Location = new System.Drawing.Point(12, 9);
            this.sliderLevelsPanel.Name = "sliderLevelsPanel";
            this.sliderLevelsPanel.Size = new System.Drawing.Size(165, 356);
            this.sliderLevelsPanel.TabIndex = 31;
            // 
            // sliderView
            // 
            this.sliderView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderView.Location = new System.Drawing.Point(200, 532);
            this.sliderView.MinimumSize = new System.Drawing.Size(0, 70);
            this.sliderView.Name = "sliderView";
            this.sliderView.Prefix = "Slider Value: ";
            this.sliderView.Size = new System.Drawing.Size(592, 70);
            this.sliderView.Suffix = "%";
            this.sliderView.TabIndex = 30;
            // 
            // devicePanel
            // 
            this.devicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devicePanel.Location = new System.Drawing.Point(803, 444);
            this.devicePanel.Margin = new System.Windows.Forms.Padding(0);
            this.devicePanel.Name = "devicePanel";
            this.devicePanel.Size = new System.Drawing.Size(281, 158);
            this.devicePanel.TabIndex = 29;
            // 
            // manipulatorPanel
            // 
            this.manipulatorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manipulatorPanel.Location = new System.Drawing.Point(200, 9);
            this.manipulatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.manipulatorPanel.Name = "manipulatorPanel";
            this.manipulatorPanel.Size = new System.Drawing.Size(887, 356);
            this.manipulatorPanel.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 614);
            this.Controls.Add(this.vslideInfoBox1);
            this.Controls.Add(this.vjoyInfoBox1);
            this.Controls.Add(this.sliderLevelsPanel);
            this.Controls.Add(this.sliderView);
            this.Controls.Add(this.devicePanel);
            this.Controls.Add(this.manipulatorPanel);
            this.Controls.Add(this.feedingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 820);
            this.MinimumSize = new System.Drawing.Size(1000, 450);
            this.Name = "MainForm";
            this.Text = "vSlide [experimental_build_1]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button feedingButton;
        private SliderManipulatorPanel manipulatorPanel;
        private DevicePanel devicePanel;
        private SliderView sliderView;
        private SliderLevelsPanel sliderLevelsPanel;
        private VjoyInfoBox vjoyInfoBox1;
        private VslideInfoBox vslideInfoBox1;
    }
}
