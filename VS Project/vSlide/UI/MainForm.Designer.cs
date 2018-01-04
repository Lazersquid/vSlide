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
            this.devicePanel = new vSlide.DevicePanel();
            this.sliderView = new vSlide.SliderView();
            this.manipulatorPanel = new vSlide.SliderManipulatorPanel();
            this.sliderLevelsPanel = new vSlide.SliderLevelsPanel();
            this.vjoyInfoBox = new vSlide.VjoyInfoBox();
            this.vslideInfoBox = new vSlide.VslideInfoBox();
            this.sliderModeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feedingButton
            // 
            this.feedingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.feedingButton.Location = new System.Drawing.Point(39, 588);
            this.feedingButton.Name = "feedingButton";
            this.feedingButton.Size = new System.Drawing.Size(118, 23);
            this.feedingButton.TabIndex = 1;
            this.feedingButton.Text = "Start";
            this.feedingButton.UseVisualStyleBackColor = true;
            this.feedingButton.Click += new System.EventHandler(this.FeedingButton_Click);
            // 
            // devicePanel
            // 
            this.devicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devicePanel.Location = new System.Drawing.Point(1103, 459);
            this.devicePanel.Name = "devicePanel";
            this.devicePanel.Size = new System.Drawing.Size(208, 76);
            this.devicePanel.TabIndex = 29;
            // 
            // sliderView
            // 
            this.sliderView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderView.Location = new System.Drawing.Point(254, 541);
            this.sliderView.MinimumSize = new System.Drawing.Size(0, 70);
            this.sliderView.Name = "sliderView";
            this.sliderView.Prefix = "Slider Value: ";
            this.sliderView.Size = new System.Drawing.Size(1057, 70);
            this.sliderView.Suffix = "%";
            this.sliderView.TabIndex = 30;
            // 
            // manipulatorPanel
            // 
            this.manipulatorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manipulatorPanel.Location = new System.Drawing.Point(254, 9);
            this.manipulatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.manipulatorPanel.MaximumManipulators = 20;
            this.manipulatorPanel.Name = "manipulatorPanel";
            this.manipulatorPanel.Size = new System.Drawing.Size(1060, 412);
            this.manipulatorPanel.TabIndex = 28;
            // 
            // sliderLevelsPanel
            // 
            this.sliderLevelsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderLevelsPanel.IsUsingCustomValues = false;
            this.sliderLevelsPanel.Location = new System.Drawing.Point(12, 12);
            this.sliderLevelsPanel.Name = "sliderLevelsPanel";
            this.sliderLevelsPanel.SeperationHeight = 2;
            this.sliderLevelsPanel.Size = new System.Drawing.Size(191, 347);
            this.sliderLevelsPanel.SliderLevelCount = 11;
            this.sliderLevelsPanel.SliderLevelPrefix = "Level ";
            this.sliderLevelsPanel.SliderLevelSuffix = "%";
            this.sliderLevelsPanel.SliderLevelTitleFixedWidth = 55;
            this.sliderLevelsPanel.TabIndex = 31;
            // 
            // vjoyInfoBox
            // 
            this.vjoyInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vjoyInfoBox.Location = new System.Drawing.Point(932, 459);
            this.vjoyInfoBox.Margin = new System.Windows.Forms.Padding(0);
            this.vjoyInfoBox.Name = "vjoyInfoBox";
            this.vjoyInfoBox.Size = new System.Drawing.Size(165, 76);
            this.vjoyInfoBox.TabIndex = 32;
            // 
            // vslideInfoBox
            // 
            this.vslideInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vslideInfoBox.Location = new System.Drawing.Point(761, 459);
            this.vslideInfoBox.Name = "vslideInfoBox";
            this.vslideInfoBox.Size = new System.Drawing.Size(165, 76);
            this.vslideInfoBox.TabIndex = 33;
            // 
            // sliderModeComboBox
            // 
            this.sliderModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sliderModeComboBox.FormattingEnabled = true;
            this.sliderModeComboBox.Location = new System.Drawing.Point(604, 488);
            this.sliderModeComboBox.Name = "sliderModeComboBox";
            this.sliderModeComboBox.Size = new System.Drawing.Size(138, 21);
            this.sliderModeComboBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Slider mode:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sliderModeComboBox);
            this.Controls.Add(this.devicePanel);
            this.Controls.Add(this.feedingButton);
            this.Controls.Add(this.sliderView);
            this.Controls.Add(this.manipulatorPanel);
            this.Controls.Add(this.sliderLevelsPanel);
            this.Controls.Add(this.vjoyInfoBox);
            this.Controls.Add(this.vslideInfoBox);
            this.MinimumSize = new System.Drawing.Size(1000, 470);
            this.Name = "MainForm";
            this.Text = "vSlide [experimental_build_1]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button feedingButton;
        private SliderManipulatorPanel manipulatorPanel;
        private SliderView sliderView;
        private SliderLevelsPanel sliderLevelsPanel;
        private VjoyInfoBox vjoyInfoBox;
        private VslideInfoBox vslideInfoBox;
        private DevicePanel devicePanel;
        private System.Windows.Forms.ComboBox sliderModeComboBox;
        private System.Windows.Forms.Label label1;
    }
}
