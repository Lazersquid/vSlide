namespace vSlide
{
    partial class VjoyInfoBox
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
            this.dllVersionTitleLabel = new System.Windows.Forms.Label();
            this.versionTitleLabel = new System.Windows.Forms.Label();
            this.vjoyInstalledTitleLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.dllVersionLabel = new System.Windows.Forms.Label();
            this.vjoyInstalledCheckBox = new System.Windows.Forms.CheckBox();
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
            this.groupBox.Size = new System.Drawing.Size(155, 121);
            this.groupBox.TabIndex = 59;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "vJoy";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dllVersionTitleLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.versionTitleLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.vjoyInstalledTitleLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.versionLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dllVersionLabel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.vjoyInstalledCheckBox, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(1, 14);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(153, 104);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // dllVersionTitleLabel
            // 
            this.dllVersionTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dllVersionTitleLabel.AutoSize = true;
            this.dllVersionTitleLabel.Location = new System.Drawing.Point(3, 42);
            this.dllVersionTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.dllVersionTitleLabel.Name = "dllVersionTitleLabel";
            this.dllVersionTitleLabel.Size = new System.Drawing.Size(58, 13);
            this.dllVersionTitleLabel.TabIndex = 48;
            this.dllVersionTitleLabel.Text = "dll Version:";
            // 
            // versionTitleLabel
            // 
            this.versionTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.versionTitleLabel.AutoSize = true;
            this.versionTitleLabel.Location = new System.Drawing.Point(3, 23);
            this.versionTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.versionTitleLabel.Name = "versionTitleLabel";
            this.versionTitleLabel.Size = new System.Drawing.Size(45, 13);
            this.versionTitleLabel.TabIndex = 47;
            this.versionTitleLabel.Text = "Version:";
            // 
            // vjoyInstalledTitleLabel
            // 
            this.vjoyInstalledTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vjoyInstalledTitleLabel.AutoSize = true;
            this.vjoyInstalledTitleLabel.Location = new System.Drawing.Point(3, 3);
            this.vjoyInstalledTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.vjoyInstalledTitleLabel.Name = "vjoyInstalledTitleLabel";
            this.vjoyInstalledTitleLabel.Size = new System.Drawing.Size(49, 13);
            this.vjoyInstalledTitleLabel.TabIndex = 43;
            this.vjoyInstalledTitleLabel.Text = "Installed:";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(67, 23);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(10, 13);
            this.versionLabel.TabIndex = 46;
            this.versionLabel.Text = "-";
            // 
            // dllVersionLabel
            // 
            this.dllVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dllVersionLabel.AutoSize = true;
            this.dllVersionLabel.Location = new System.Drawing.Point(67, 42);
            this.dllVersionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.dllVersionLabel.Name = "dllVersionLabel";
            this.dllVersionLabel.Size = new System.Drawing.Size(10, 13);
            this.dllVersionLabel.TabIndex = 49;
            this.dllVersionLabel.Text = "-";
            // 
            // vjoyInstalledCheckBox
            // 
            this.vjoyInstalledCheckBox.AutoSize = true;
            this.vjoyInstalledCheckBox.Enabled = false;
            this.vjoyInstalledCheckBox.Location = new System.Drawing.Point(67, 3);
            this.vjoyInstalledCheckBox.Name = "vjoyInstalledCheckBox";
            this.vjoyInstalledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.vjoyInstalledCheckBox.TabIndex = 50;
            this.vjoyInstalledCheckBox.UseVisualStyleBackColor = true;
            // 
            // VjoyInfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "VjoyInfoBox";
            this.Size = new System.Drawing.Size(155, 121);
            this.groupBox.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label dllVersionTitleLabel;
        private System.Windows.Forms.Label versionTitleLabel;
        private System.Windows.Forms.Label vjoyInstalledTitleLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label dllVersionLabel;
        private System.Windows.Forms.CheckBox vjoyInstalledCheckBox;
    }
}
