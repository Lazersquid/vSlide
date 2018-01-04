namespace vSlide
{
    partial class WhenKeyReleasedTriggerFactory
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.maxPressTimeDecimalControl = new vSlide.DecimalControl();
            this.keyBindControl = new vSlide.KeyBindControl();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.maxPressTimeDecimalControl, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.keyBindControl, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(409, 20);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(99, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "On key released";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxPressTimeDecimalControl
            // 
            this.maxPressTimeDecimalControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxPressTimeDecimalControl.AutoSize = true;
            this.maxPressTimeDecimalControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxPressTimeDecimalControl.DecimalDigits = 0;
            this.maxPressTimeDecimalControl.FixedTitleWidth = -1;
            this.maxPressTimeDecimalControl.IsTitleSizeFixed = false;
            this.maxPressTimeDecimalControl.IsValueEditableByUser = true;
            this.maxPressTimeDecimalControl.Location = new System.Drawing.Point(265, 0);
            this.maxPressTimeDecimalControl.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.maxPressTimeDecimalControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxPressTimeDecimalControl.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.maxPressTimeDecimalControl.Name = "maxPressTimeDecimalControl";
            this.maxPressTimeDecimalControl.NumericUpDownIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxPressTimeDecimalControl.NumericUpDownWidth = 44;
            this.maxPressTimeDecimalControl.Resolution = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxPressTimeDecimalControl.Size = new System.Drawing.Size(144, 20);
            this.maxPressTimeDecimalControl.Suffix = "ms";
            this.maxPressTimeDecimalControl.TabIndex = 1;
            this.maxPressTimeDecimalControl.Title = "Max press time:";
            this.maxPressTimeDecimalControl.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.maxPressTimeDecimalControl.ValueAsFactor = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // keyBindControl
            // 
            this.keyBindControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keyBindControl.AutoSize = true;
            this.keyBindControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.keyBindControl.Location = new System.Drawing.Point(99, 0);
            this.keyBindControl.Margin = new System.Windows.Forms.Padding(0);
            this.keyBindControl.Name = "keyBindControl";
            this.keyBindControl.Size = new System.Drawing.Size(146, 20);
            this.keyBindControl.TabIndex = 2;
            this.keyBindControl.Title = "Key:";
            // 
            // WhenKeyReleasedTriggerFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WhenKeyReleasedTriggerFactory";
            this.Size = new System.Drawing.Size(409, 20);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private KeyBindControl keyBindControl;
        private DecimalControl maxPressTimeDecimalControl;
    }
}
