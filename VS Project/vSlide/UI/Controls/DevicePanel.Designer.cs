namespace vSlide
{
    partial class DevicePanel
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
            this.deviceGroupBox = new System.Windows.Forms.GroupBox();
            this.deviceTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.acquiredDeviceIdLabel = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.deviceListCombobox = new System.Windows.Forms.ComboBox();
            this.acquireButton = new System.Windows.Forms.Button();
            this.deviceGroupBox.SuspendLayout();
            this.deviceTablePanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceGroupBox
            // 
            this.deviceGroupBox.Controls.Add(this.deviceTablePanel);
            this.deviceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceGroupBox.Location = new System.Drawing.Point(0, 0);
            this.deviceGroupBox.Name = "deviceGroupBox";
            this.deviceGroupBox.Size = new System.Drawing.Size(216, 153);
            this.deviceGroupBox.TabIndex = 4;
            this.deviceGroupBox.TabStop = false;
            this.deviceGroupBox.Text = "vJoy device";
            // 
            // deviceTablePanel
            // 
            this.deviceTablePanel.ColumnCount = 1;
            this.deviceTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.deviceTablePanel.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.deviceTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceTablePanel.Location = new System.Drawing.Point(3, 16);
            this.deviceTablePanel.Name = "deviceTablePanel";
            this.deviceTablePanel.RowCount = 3;
            this.deviceTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.deviceTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.deviceTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.deviceTablePanel.Size = new System.Drawing.Size(210, 134);
            this.deviceTablePanel.TabIndex = 76;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.acquiredDeviceIdLabel, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label89, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label104, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.deviceListCombobox, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.acquireButton, 2, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(204, 128);
            this.tableLayoutPanel6.TabIndex = 82;
            // 
            // acquiredDeviceIdLabel
            // 
            this.acquiredDeviceIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.acquiredDeviceIdLabel.AutoSize = true;
            this.acquiredDeviceIdLabel.Location = new System.Drawing.Point(102, 0);
            this.acquiredDeviceIdLabel.Name = "acquiredDeviceIdLabel";
            this.acquiredDeviceIdLabel.Size = new System.Drawing.Size(10, 13);
            this.acquiredDeviceIdLabel.TabIndex = 75;
            this.acquiredDeviceIdLabel.Text = "-";
            // 
            // label89
            // 
            this.label89.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(3, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(87, 13);
            this.label89.TabIndex = 75;
            this.label89.Text = "Acquired device:";
            // 
            // label104
            // 
            this.label104.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(3, 21);
            this.label104.Margin = new System.Windows.Forms.Padding(3);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(93, 13);
            this.label104.TabIndex = 35;
            this.label104.Text = "Available devices:";
            // 
            // deviceListCombobox
            // 
            this.deviceListCombobox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceListCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceListCombobox.FormattingEnabled = true;
            this.deviceListCombobox.Items.AddRange(new object[] {
            "None"});
            this.deviceListCombobox.Location = new System.Drawing.Point(102, 17);
            this.deviceListCombobox.Name = "deviceListCombobox";
            this.deviceListCombobox.Size = new System.Drawing.Size(35, 21);
            this.deviceListCombobox.TabIndex = 38;
            // 
            // acquireButton
            // 
            this.acquireButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.acquireButton.Location = new System.Drawing.Point(143, 16);
            this.acquireButton.MinimumSize = new System.Drawing.Size(0, 23);
            this.acquireButton.Name = "acquireButton";
            this.acquireButton.Size = new System.Drawing.Size(51, 23);
            this.acquireButton.TabIndex = 45;
            this.acquireButton.Text = "Acquire";
            this.acquireButton.UseVisualStyleBackColor = true;
            // 
            // DevicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deviceGroupBox);
            this.Name = "DevicePanel";
            this.Size = new System.Drawing.Size(216, 153);
            this.deviceGroupBox.ResumeLayout(false);
            this.deviceTablePanel.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox deviceGroupBox;
        private System.Windows.Forms.TableLayoutPanel deviceTablePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label acquiredDeviceIdLabel;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.ComboBox deviceListCombobox;
        private System.Windows.Forms.Button acquireButton;
    }
}
