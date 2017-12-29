namespace vSlide
{
    partial class SliderLevelsPanel
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
            this.mainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.levelFactoriesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.metaValuesTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.customValuesTitleLabel = new System.Windows.Forms.Label();
            this.customValuesCheckBox = new System.Windows.Forms.CheckBox();
            this.levelCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.levelCountTitleLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.mainTablePanel.SuspendLayout();
            this.metaValuesTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.mainTablePanel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(168, 313);
            this.groupBox.TabIndex = 56;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Slider levels";
            // 
            // mainTablePanel
            // 
            this.mainTablePanel.ColumnCount = 1;
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.Controls.Add(this.levelFactoriesFlowPanel, 0, 1);
            this.mainTablePanel.Controls.Add(this.metaValuesTablePanel, 0, 0);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(3, 16);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.RowCount = 2;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.Size = new System.Drawing.Size(162, 294);
            this.mainTablePanel.TabIndex = 0;
            // 
            // levelFactoriesFlowPanel
            // 
            this.levelFactoriesFlowPanel.AutoScroll = true;
            this.levelFactoriesFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.levelFactoriesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelFactoriesFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.levelFactoriesFlowPanel.Location = new System.Drawing.Point(3, 56);
            this.levelFactoriesFlowPanel.Name = "levelFactoriesFlowPanel";
            this.levelFactoriesFlowPanel.Size = new System.Drawing.Size(156, 235);
            this.levelFactoriesFlowPanel.TabIndex = 59;
            this.levelFactoriesFlowPanel.WrapContents = false;
            // 
            // metaValuesTablePanel
            // 
            this.metaValuesTablePanel.AutoSize = true;
            this.metaValuesTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metaValuesTablePanel.ColumnCount = 2;
            this.metaValuesTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.metaValuesTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.metaValuesTablePanel.Controls.Add(this.customValuesTitleLabel, 0, 1);
            this.metaValuesTablePanel.Controls.Add(this.customValuesCheckBox, 1, 1);
            this.metaValuesTablePanel.Controls.Add(this.levelCountNumericUpDown, 1, 0);
            this.metaValuesTablePanel.Controls.Add(this.levelCountTitleLabel, 0, 0);
            this.metaValuesTablePanel.Location = new System.Drawing.Point(3, 3);
            this.metaValuesTablePanel.Name = "metaValuesTablePanel";
            this.metaValuesTablePanel.RowCount = 2;
            this.metaValuesTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.metaValuesTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.metaValuesTablePanel.Size = new System.Drawing.Size(127, 46);
            this.metaValuesTablePanel.TabIndex = 60;
            // 
            // customValuesTitleLabel
            // 
            this.customValuesTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customValuesTitleLabel.AutoSize = true;
            this.customValuesTitleLabel.Location = new System.Drawing.Point(3, 29);
            this.customValuesTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.customValuesTitleLabel.Name = "customValuesTitleLabel";
            this.customValuesTitleLabel.Size = new System.Drawing.Size(76, 13);
            this.customValuesTitleLabel.TabIndex = 38;
            this.customValuesTitleLabel.Text = "Custom values";
            // 
            // customValuesCheckBox
            // 
            this.customValuesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customValuesCheckBox.AutoSize = true;
            this.customValuesCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customValuesCheckBox.Location = new System.Drawing.Point(85, 29);
            this.customValuesCheckBox.Name = "customValuesCheckBox";
            this.customValuesCheckBox.Size = new System.Drawing.Size(15, 14);
            this.customValuesCheckBox.TabIndex = 37;
            this.customValuesCheckBox.UseVisualStyleBackColor = true;
            // 
            // levelCountNumericUpDown
            // 
            this.levelCountNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.levelCountNumericUpDown.Location = new System.Drawing.Point(85, 3);
            this.levelCountNumericUpDown.Name = "levelCountNumericUpDown";
            this.levelCountNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.levelCountNumericUpDown.TabIndex = 36;
            this.levelCountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // levelCountTitleLabel
            // 
            this.levelCountTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.levelCountTitleLabel.AutoSize = true;
            this.levelCountTitleLabel.Location = new System.Drawing.Point(3, 6);
            this.levelCountTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.levelCountTitleLabel.Name = "levelCountTitleLabel";
            this.levelCountTitleLabel.Size = new System.Drawing.Size(63, 13);
            this.levelCountTitleLabel.TabIndex = 35;
            this.levelCountTitleLabel.Text = "Level count";
            // 
            // SliderLevelsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "SliderLevelsPanel";
            this.Size = new System.Drawing.Size(168, 313);
            this.groupBox.ResumeLayout(false);
            this.mainTablePanel.ResumeLayout(false);
            this.mainTablePanel.PerformLayout();
            this.metaValuesTablePanel.ResumeLayout(false);
            this.metaValuesTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.FlowLayoutPanel levelFactoriesFlowPanel;
        private System.Windows.Forms.TableLayoutPanel metaValuesTablePanel;
        private System.Windows.Forms.Label customValuesTitleLabel;
        private System.Windows.Forms.CheckBox customValuesCheckBox;
        private System.Windows.Forms.NumericUpDown levelCountNumericUpDown;
        private System.Windows.Forms.Label levelCountTitleLabel;
    }
}
