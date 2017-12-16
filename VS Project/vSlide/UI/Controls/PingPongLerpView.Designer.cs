namespace vSlide.UI.Controls
{
    partial class PingPongLerpView
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.amountTitleLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activatedCheckBox = new System.Windows.Forms.CheckBox();
            this.activatedTitleLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.tableLayoutPanel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox.Size = new System.Drawing.Size(218, 113);
            this.groupBox.TabIndex = 64;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ping-Pong interpolation";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.activatedCheckBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.activatedTitleLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.amountNumericUpDown, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.amountTitleLabel, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 13);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(218, 100);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // amountTitleLabel
            // 
            this.amountTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountTitleLabel.AutoSize = true;
            this.amountTitleLabel.Location = new System.Drawing.Point(3, 18);
            this.amountTitleLabel.Name = "amountTitleLabel";
            this.amountTitleLabel.Size = new System.Drawing.Size(46, 13);
            this.amountTitleLabel.TabIndex = 32;
            this.amountTitleLabel.Text = "Amount:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountNumericUpDown.BackColor = System.Drawing.Color.Gainsboro;
            this.amountNumericUpDown.DecimalPlaces = 1;
            this.amountNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amountNumericUpDown.Location = new System.Drawing.Point(64, 15);
            this.amountNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.amountNumericUpDown.TabIndex = 38;
            this.amountNumericUpDown.Tag = "";
            this.amountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // activatedCheckBox
            // 
            this.activatedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.activatedCheckBox.AutoSize = true;
            this.activatedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activatedCheckBox.Location = new System.Drawing.Point(64, 68);
            this.activatedCheckBox.Name = "activatedCheckBox";
            this.activatedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.activatedCheckBox.TabIndex = 29;
            this.activatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // activatedTitleLabel
            // 
            this.activatedTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.activatedTitleLabel.AutoSize = true;
            this.activatedTitleLabel.Location = new System.Drawing.Point(3, 68);
            this.activatedTitleLabel.Name = "activatedTitleLabel";
            this.activatedTitleLabel.Size = new System.Drawing.Size(55, 13);
            this.activatedTitleLabel.TabIndex = 33;
            this.activatedTitleLabel.Text = "Activated:";
            // 
            // PingPongLerpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "PingPongLerpView";
            this.Size = new System.Drawing.Size(218, 113);
            this.groupBox.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.CheckBox activatedCheckBox;
        private System.Windows.Forms.Label activatedTitleLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Label amountTitleLabel;
    }
}
