namespace vSlide
{
    partial class SliderManipulatorFactory
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.arrowLabel = new System.Windows.Forms.Label();
            this.triggerFactoryComboBox = new System.Windows.Forms.ComboBox();
            this.actionFactoryComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 6;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.deleteButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.arrowLabel, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.triggerFactoryComboBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.actionFactoryComboBox, 4, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(183, 28);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(0, 0);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(28, 28);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // arrowLabel
            // 
            this.arrowLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arrowLabel.AutoSize = true;
            this.arrowLabel.Location = new System.Drawing.Point(116, 7);
            this.arrowLabel.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(19, 13);
            this.arrowLabel.TabIndex = 29;
            this.arrowLabel.Text = "-->";
            // 
            // triggerFactoryComboBox
            // 
            this.triggerFactoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.triggerFactoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.triggerFactoryComboBox.DropDownWidth = 200;
            this.triggerFactoryComboBox.FormattingEnabled = true;
            this.triggerFactoryComboBox.Location = new System.Drawing.Point(68, 3);
            this.triggerFactoryComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.triggerFactoryComboBox.Name = "triggerFactoryComboBox";
            this.triggerFactoryComboBox.Size = new System.Drawing.Size(18, 21);
            this.triggerFactoryComboBox.TabIndex = 30;
            // 
            // actionFactoryComboBox
            // 
            this.actionFactoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.actionFactoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionFactoryComboBox.DropDownWidth = 200;
            this.actionFactoryComboBox.FormattingEnabled = true;
            this.actionFactoryComboBox.Location = new System.Drawing.Point(165, 3);
            this.actionFactoryComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.actionFactoryComboBox.Name = "actionFactoryComboBox";
            this.actionFactoryComboBox.Size = new System.Drawing.Size(18, 21);
            this.actionFactoryComboBox.TabIndex = 31;
            // 
            // SliderManipulatorFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(140, 2);
            this.Name = "SliderManipulatorFactory";
            this.Size = new System.Drawing.Size(183, 28);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label arrowLabel;
        private System.Windows.Forms.ComboBox triggerFactoryComboBox;
        private System.Windows.Forms.ComboBox actionFactoryComboBox;
    }
}
