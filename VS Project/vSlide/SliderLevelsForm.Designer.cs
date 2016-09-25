namespace vSlide
{
    partial class SliderLevelsForm
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
            this.mappingLevelPrototypeGroupBox = new System.Windows.Forms.GroupBox();
            this.percentPrototypeInfoLabel = new System.Windows.Forms.Label();
            this.relativeValuePrototypeInfoLabel = new System.Windows.Forms.Label();
            this.relativePrototypeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setValuesEqualyButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.sliderLevelsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.numberOfLevelsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.revertSliderLevelToDefaultButton = new System.Windows.Forms.Button();
            this.saveSliderLevelsButton = new System.Windows.Forms.Button();
            this.revertSliderLevelsButton = new System.Windows.Forms.Button();
            this.mappingLevelPrototypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relativePrototypeNumericUpDown)).BeginInit();
            this.sliderLevelsFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLevelsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mappingLevelPrototypeGroupBox
            // 
            this.mappingLevelPrototypeGroupBox.Controls.Add(this.percentPrototypeInfoLabel);
            this.mappingLevelPrototypeGroupBox.Controls.Add(this.relativeValuePrototypeInfoLabel);
            this.mappingLevelPrototypeGroupBox.Controls.Add(this.relativePrototypeNumericUpDown);
            this.mappingLevelPrototypeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.mappingLevelPrototypeGroupBox.Name = "mappingLevelPrototypeGroupBox";
            this.mappingLevelPrototypeGroupBox.Size = new System.Drawing.Size(136, 48);
            this.mappingLevelPrototypeGroupBox.TabIndex = 36;
            this.mappingLevelPrototypeGroupBox.TabStop = false;
            this.mappingLevelPrototypeGroupBox.Text = "Level 1";
            this.mappingLevelPrototypeGroupBox.Visible = false;
            // 
            // percentPrototypeInfoLabel
            // 
            this.percentPrototypeInfoLabel.AutoSize = true;
            this.percentPrototypeInfoLabel.Location = new System.Drawing.Point(114, 23);
            this.percentPrototypeInfoLabel.Name = "percentPrototypeInfoLabel";
            this.percentPrototypeInfoLabel.Size = new System.Drawing.Size(15, 13);
            this.percentPrototypeInfoLabel.TabIndex = 17;
            this.percentPrototypeInfoLabel.Text = "%";
            // 
            // relativeValuePrototypeInfoLabel
            // 
            this.relativeValuePrototypeInfoLabel.AutoSize = true;
            this.relativeValuePrototypeInfoLabel.Location = new System.Drawing.Point(12, 21);
            this.relativeValuePrototypeInfoLabel.Name = "relativeValuePrototypeInfoLabel";
            this.relativeValuePrototypeInfoLabel.Size = new System.Drawing.Size(37, 13);
            this.relativeValuePrototypeInfoLabel.TabIndex = 14;
            this.relativeValuePrototypeInfoLabel.Text = "Value:";
            // 
            // relativePrototypeNumericUpDown
            // 
            this.relativePrototypeNumericUpDown.DecimalPlaces = 2;
            this.relativePrototypeNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.relativePrototypeNumericUpDown.Location = new System.Drawing.Point(55, 19);
            this.relativePrototypeNumericUpDown.Name = "relativePrototypeNumericUpDown";
            this.relativePrototypeNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.relativePrototypeNumericUpDown.TabIndex = 16;
            // 
            // setValuesEqualyButton
            // 
            this.setValuesEqualyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setValuesEqualyButton.Location = new System.Drawing.Point(191, 33);
            this.setValuesEqualyButton.Name = "setValuesEqualyButton";
            this.setValuesEqualyButton.Size = new System.Drawing.Size(96, 38);
            this.setValuesEqualyButton.TabIndex = 39;
            this.setValuesEqualyButton.Text = "Arrange Levels Equaly";
            this.setValuesEqualyButton.UseVisualStyleBackColor = true;
            this.setValuesEqualyButton.Click += new System.EventHandler(this.setValuesEqualyButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Number of Levels:";
            // 
            // sliderLevelsFlowLayoutPanel
            // 
            this.sliderLevelsFlowLayoutPanel.AutoScroll = true;
            this.sliderLevelsFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.sliderLevelsFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sliderLevelsFlowLayoutPanel.Controls.Add(this.mappingLevelPrototypeGroupBox);
            this.sliderLevelsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sliderLevelsFlowLayoutPanel.Location = new System.Drawing.Point(12, 33);
            this.sliderLevelsFlowLayoutPanel.Name = "sliderLevelsFlowLayoutPanel";
            this.sliderLevelsFlowLayoutPanel.Size = new System.Drawing.Size(164, 552);
            this.sliderLevelsFlowLayoutPanel.TabIndex = 35;
            this.sliderLevelsFlowLayoutPanel.WrapContents = false;
            // 
            // numberOfLevelsNumericUpDown
            // 
            this.numberOfLevelsNumericUpDown.Location = new System.Drawing.Point(112, 7);
            this.numberOfLevelsNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfLevelsNumericUpDown.Name = "numberOfLevelsNumericUpDown";
            this.numberOfLevelsNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.numberOfLevelsNumericUpDown.TabIndex = 38;
            this.numberOfLevelsNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfLevelsNumericUpDown.ValueChanged += new System.EventHandler(this.numberOfLevelsNumericUpDown_ValueChanged);
            // 
            // revertSliderLevelToDefaultButton
            // 
            this.revertSliderLevelToDefaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.revertSliderLevelToDefaultButton.Location = new System.Drawing.Point(191, 484);
            this.revertSliderLevelToDefaultButton.Name = "revertSliderLevelToDefaultButton";
            this.revertSliderLevelToDefaultButton.Size = new System.Drawing.Size(96, 23);
            this.revertSliderLevelToDefaultButton.TabIndex = 41;
            this.revertSliderLevelToDefaultButton.Text = "Revert to Default";
            this.revertSliderLevelToDefaultButton.UseVisualStyleBackColor = true;
            this.revertSliderLevelToDefaultButton.Click += new System.EventHandler(this.revertSliderLevelToDefaultButton_Click);
            // 
            // saveSliderLevelsButton
            // 
            this.saveSliderLevelsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSliderLevelsButton.Location = new System.Drawing.Point(191, 562);
            this.saveSliderLevelsButton.Name = "saveSliderLevelsButton";
            this.saveSliderLevelsButton.Size = new System.Drawing.Size(96, 23);
            this.saveSliderLevelsButton.TabIndex = 40;
            this.saveSliderLevelsButton.Text = "Save Changes";
            this.saveSliderLevelsButton.UseVisualStyleBackColor = true;
            this.saveSliderLevelsButton.Click += new System.EventHandler(this.saveSliderLevelsButton_Click);
            // 
            // revertSliderLevelsButton
            // 
            this.revertSliderLevelsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.revertSliderLevelsButton.Location = new System.Drawing.Point(191, 533);
            this.revertSliderLevelsButton.Name = "revertSliderLevelsButton";
            this.revertSliderLevelsButton.Size = new System.Drawing.Size(96, 23);
            this.revertSliderLevelsButton.TabIndex = 42;
            this.revertSliderLevelsButton.Text = "Revert Changes";
            this.revertSliderLevelsButton.UseVisualStyleBackColor = true;
            this.revertSliderLevelsButton.Click += new System.EventHandler(this.revertSliderLevelsButton_Click);
            // 
            // SliderLevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 599);
            this.Controls.Add(this.revertSliderLevelsButton);
            this.Controls.Add(this.revertSliderLevelToDefaultButton);
            this.Controls.Add(this.saveSliderLevelsButton);
            this.Controls.Add(this.setValuesEqualyButton);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.sliderLevelsFlowLayoutPanel);
            this.Controls.Add(this.numberOfLevelsNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SliderLevelsForm";
            this.Text = "vSlide - Slider Levels";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SliderLevelsForm_FormClosing);
            this.mappingLevelPrototypeGroupBox.ResumeLayout(false);
            this.mappingLevelPrototypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relativePrototypeNumericUpDown)).EndInit();
            this.sliderLevelsFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLevelsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mappingLevelPrototypeGroupBox;
        private System.Windows.Forms.Label relativeValuePrototypeInfoLabel;
        private System.Windows.Forms.NumericUpDown relativePrototypeNumericUpDown;
        private System.Windows.Forms.Button setValuesEqualyButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel sliderLevelsFlowLayoutPanel;
        private System.Windows.Forms.NumericUpDown numberOfLevelsNumericUpDown;
        private System.Windows.Forms.Button revertSliderLevelToDefaultButton;
        private System.Windows.Forms.Button saveSliderLevelsButton;
        private System.Windows.Forms.Button revertSliderLevelsButton;
        private System.Windows.Forms.Label percentPrototypeInfoLabel;
    }
}