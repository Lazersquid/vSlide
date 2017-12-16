namespace vSlide
{
    partial class ModifySliderValueActionFactory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.deltaDecimalControl = new vSlide.DecimalControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deltaDecimalControl, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 20);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(84, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Alter slider by";
            // 
            // deltaDecimalControl
            // 
            this.deltaDecimalControl.AutoSize = true;
            this.deltaDecimalControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deltaDecimalControl.DecimalDigits = 1;
            this.deltaDecimalControl.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.deltaDecimalControl.Location = new System.Drawing.Point(84, 0);
            this.deltaDecimalControl.Margin = new System.Windows.Forms.Padding(0);
            this.deltaDecimalControl.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.deltaDecimalControl.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.deltaDecimalControl.Name = "deltaDecimalControl";
            this.deltaDecimalControl.Size = new System.Drawing.Size(110, 20);
            this.deltaDecimalControl.StepSize = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.deltaDecimalControl.Suffix = "ms";
            this.deltaDecimalControl.TabIndex = 1;
            this.deltaDecimalControl.Title = "Amount:";
            this.deltaDecimalControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ModifySliderValueActionFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ModifySliderValueActionFactory";
            this.Size = new System.Drawing.Size(195, 21);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private DecimalControl deltaDecimalControl;
    }
}
