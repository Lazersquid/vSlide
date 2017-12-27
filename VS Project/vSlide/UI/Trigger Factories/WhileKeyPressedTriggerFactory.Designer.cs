namespace vSlide
{
    partial class WhileKeyPressedTriggerFactory
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tresholdDecimalControl = new vSlide.DecimalControl();
            this.titleLabel = new System.Windows.Forms.Label();
            this.keyBindControl = new vSlide.KeyBindControl();
            this.intervalDecimalControl = new vSlide.DecimalControl();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.tresholdDecimalControl, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.keyBindControl, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.intervalDecimalControl, 3, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(521, 23);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tresholdDecimalControl
            // 
            this.tresholdDecimalControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tresholdDecimalControl.AutoSize = true;
            this.tresholdDecimalControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tresholdDecimalControl.DecimalDigits = 0;
            this.tresholdDecimalControl.Location = new System.Drawing.Point(277, 1);
            this.tresholdDecimalControl.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tresholdDecimalControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tresholdDecimalControl.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tresholdDecimalControl.Name = "tresholdDecimalControl";
            this.tresholdDecimalControl.NumericUpDownIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tresholdDecimalControl.NumericUpDownWidth = 44;
            this.tresholdDecimalControl.Resolution = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tresholdDecimalControl.Size = new System.Drawing.Size(115, 20);
            this.tresholdDecimalControl.Suffix = "ms";
            this.tresholdDecimalControl.TabIndex = 1;
            this.tresholdDecimalControl.Title = "Treshold:";
            this.tresholdDecimalControl.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 5);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(111, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "While key pressed";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // keyBindControl
            // 
            this.keyBindControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keyBindControl.AutoSize = true;
            this.keyBindControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.keyBindControl.Location = new System.Drawing.Point(111, 0);
            this.keyBindControl.Margin = new System.Windows.Forms.Padding(0);
            this.keyBindControl.Name = "keyBindControl";
            this.keyBindControl.Size = new System.Drawing.Size(146, 23);
            this.keyBindControl.TabIndex = 2;
            this.keyBindControl.Title = "Key:";
            // 
            // intervalDecimalControl
            // 
            this.intervalDecimalControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.intervalDecimalControl.AutoSize = true;
            this.intervalDecimalControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.intervalDecimalControl.DecimalDigits = 0;
            this.intervalDecimalControl.Location = new System.Drawing.Point(412, 1);
            this.intervalDecimalControl.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.intervalDecimalControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.intervalDecimalControl.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intervalDecimalControl.Name = "intervalDecimalControl";
            this.intervalDecimalControl.NumericUpDownIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intervalDecimalControl.NumericUpDownWidth = 44;
            this.intervalDecimalControl.Resolution = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intervalDecimalControl.Size = new System.Drawing.Size(109, 20);
            this.intervalDecimalControl.Suffix = "ms";
            this.intervalDecimalControl.TabIndex = 3;
            this.intervalDecimalControl.Title = "Interval:";
            this.intervalDecimalControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // WhileKeyPressedTriggerFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WhileKeyPressedTriggerFactory";
            this.Size = new System.Drawing.Size(521, 23);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private KeyBindControl keyBindControl;
        private DecimalControl tresholdDecimalControl;
        private DecimalControl intervalDecimalControl;
    }
}
