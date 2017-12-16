namespace vSlide
{
    partial class VslideInfoBox
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
            this.forVjoyVersionTitleLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionTitleLabel = new System.Windows.Forms.Label();
            this.forVjoyVersionLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.tableLayoutPanel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            this.groupBox.Size = new System.Drawing.Size(203, 141);
            this.groupBox.TabIndex = 60;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "vSlide";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.forVjoyVersionTitleLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.versionLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.versionTitleLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.forVjoyVersionLabel, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(1, 14);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(201, 124);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // forVjoyVersionTitleLabel
            // 
            this.forVjoyVersionTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.forVjoyVersionTitleLabel.AutoSize = true;
            this.forVjoyVersionTitleLabel.Location = new System.Drawing.Point(3, 22);
            this.forVjoyVersionTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.forVjoyVersionTitleLabel.Name = "forVjoyVersionTitleLabel";
            this.forVjoyVersionTitleLabel.Size = new System.Drawing.Size(87, 13);
            this.forVjoyVersionTitleLabel.TabIndex = 47;
            this.forVjoyVersionTitleLabel.Text = "Created for vJoy:";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(96, 3);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(48, 13);
            this.versionLabel.TabIndex = 45;
            this.versionLabel.Text = "2.0 [exp]";
            // 
            // versionTitleLabel
            // 
            this.versionTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.versionTitleLabel.AutoSize = true;
            this.versionTitleLabel.Location = new System.Drawing.Point(3, 3);
            this.versionTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.versionTitleLabel.Name = "versionTitleLabel";
            this.versionTitleLabel.Size = new System.Drawing.Size(45, 13);
            this.versionTitleLabel.TabIndex = 43;
            this.versionTitleLabel.Text = "Version:";
            // 
            // forVjoyVersionLabel
            // 
            this.forVjoyVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.forVjoyVersionLabel.AutoSize = true;
            this.forVjoyVersionLabel.Location = new System.Drawing.Point(96, 22);
            this.forVjoyVersionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.forVjoyVersionLabel.Name = "forVjoyVersionLabel";
            this.forVjoyVersionLabel.Size = new System.Drawing.Size(30, 13);
            this.forVjoyVersionLabel.TabIndex = 46;
            this.forVjoyVersionLabel.Text = "2.8.x";
            // 
            // VslideInfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "VslideInfoBox";
            this.Size = new System.Drawing.Size(203, 141);
            this.groupBox.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label forVjoyVersionTitleLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label versionTitleLabel;
        private System.Windows.Forms.Label forVjoyVersionLabel;
    }
}
