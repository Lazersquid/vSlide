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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.setValuesEqualyButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.mappingThemeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.numberOfLevelsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.revertSliderLevelToDefaultButton = new System.Windows.Forms.Button();
            this.saveSliderLevelsButton = new System.Windows.Forms.Button();
            this.mappingLevelPrototypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLevelsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mappingLevelPrototypeGroupBox
            // 
            this.mappingLevelPrototypeGroupBox.Controls.Add(this.label7);
            this.mappingLevelPrototypeGroupBox.Controls.Add(this.label8);
            this.mappingLevelPrototypeGroupBox.Controls.Add(this.label9);
            this.mappingLevelPrototypeGroupBox.Controls.Add(this.label10);
            this.mappingLevelPrototypeGroupBox.Controls.Add(this.numericUpDown1);
            this.mappingLevelPrototypeGroupBox.Controls.Add(this.numericUpDown2);
            this.mappingLevelPrototypeGroupBox.Location = new System.Drawing.Point(321, 33);
            this.mappingLevelPrototypeGroupBox.Name = "mappingLevelPrototypeGroupBox";
            this.mappingLevelPrototypeGroupBox.Size = new System.Drawing.Size(295, 68);
            this.mappingLevelPrototypeGroupBox.TabIndex = 36;
            this.mappingLevelPrototypeGroupBox.TabStop = false;
            this.mappingLevelPrototypeGroupBox.Text = "Level 1";
            this.mappingLevelPrototypeGroupBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Absolute Value:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "-";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Relative Value:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(200, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(200, 16);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.ThousandsSeparator = true;
            // 
            // setValuesEqualyButton
            // 
            this.setValuesEqualyButton.Location = new System.Drawing.Point(187, 4);
            this.setValuesEqualyButton.Name = "setValuesEqualyButton";
            this.setValuesEqualyButton.Size = new System.Drawing.Size(128, 23);
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
            // mappingThemeFlowLayoutPanel
            // 
            this.mappingThemeFlowLayoutPanel.AutoScroll = true;
            this.mappingThemeFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mappingThemeFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mappingThemeFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mappingThemeFlowLayoutPanel.Location = new System.Drawing.Point(12, 33);
            this.mappingThemeFlowLayoutPanel.Name = "mappingThemeFlowLayoutPanel";
            this.mappingThemeFlowLayoutPanel.Size = new System.Drawing.Size(303, 586);
            this.mappingThemeFlowLayoutPanel.TabIndex = 35;
            this.mappingThemeFlowLayoutPanel.WrapContents = false;
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
            this.revertSliderLevelToDefaultButton.Location = new System.Drawing.Point(214, 631);
            this.revertSliderLevelToDefaultButton.Name = "revertSliderLevelToDefaultButton";
            this.revertSliderLevelToDefaultButton.Size = new System.Drawing.Size(101, 23);
            this.revertSliderLevelToDefaultButton.TabIndex = 41;
            this.revertSliderLevelToDefaultButton.Text = "Revert to Default";
            this.revertSliderLevelToDefaultButton.UseVisualStyleBackColor = true;
            // 
            // saveSliderLevelsButton
            // 
            this.saveSliderLevelsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveSliderLevelsButton.Location = new System.Drawing.Point(12, 631);
            this.saveSliderLevelsButton.Name = "saveSliderLevelsButton";
            this.saveSliderLevelsButton.Size = new System.Drawing.Size(53, 23);
            this.saveSliderLevelsButton.TabIndex = 40;
            this.saveSliderLevelsButton.Text = "Save";
            this.saveSliderLevelsButton.UseVisualStyleBackColor = true;
            // 
            // MappingThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 666);
            this.Controls.Add(this.revertSliderLevelToDefaultButton);
            this.Controls.Add(this.saveSliderLevelsButton);
            this.Controls.Add(this.mappingLevelPrototypeGroupBox);
            this.Controls.Add(this.setValuesEqualyButton);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.mappingThemeFlowLayoutPanel);
            this.Controls.Add(this.numberOfLevelsNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MappingThemeForm";
            this.Text = "vSlide - Slider Levels";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SliderLevelsForm_FormClosing);
            this.mappingLevelPrototypeGroupBox.ResumeLayout(false);
            this.mappingLevelPrototypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLevelsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mappingLevelPrototypeGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button setValuesEqualyButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel mappingThemeFlowLayoutPanel;
        private System.Windows.Forms.NumericUpDown numberOfLevelsNumericUpDown;
        private System.Windows.Forms.Button revertSliderLevelToDefaultButton;
        private System.Windows.Forms.Button saveSliderLevelsButton;
    }
}