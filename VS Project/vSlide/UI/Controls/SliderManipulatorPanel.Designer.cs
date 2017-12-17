namespace vSlide
{
    partial class SliderManipulatorPanel
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
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.manipulatorsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rebindGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.applyButton = new System.Windows.Forms.Button();
            this.detectButton = new System.Windows.Forms.Button();
            this.keyComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.altComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.ctrlComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addManipulatorButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.rebindGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rebindGroupBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addManipulatorButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 329);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.manipulatorsPanel);
            this.mainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mainGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            this.mainGroupBox.Size = new System.Drawing.Size(828, 209);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Slider manipulators";
            // 
            // manipulatorsPanel
            // 
            this.manipulatorsPanel.AutoScroll = true;
            this.manipulatorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manipulatorsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.manipulatorsPanel.Location = new System.Drawing.Point(1, 14);
            this.manipulatorsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.manipulatorsPanel.Name = "manipulatorsPanel";
            this.manipulatorsPanel.Size = new System.Drawing.Size(826, 192);
            this.manipulatorsPanel.TabIndex = 0;
            this.manipulatorsPanel.WrapContents = false;
            // 
            // rebindGroupBox
            // 
            this.rebindGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.rebindGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rebindGroupBox.Location = new System.Drawing.Point(0, 279);
            this.rebindGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.rebindGroupBox.Name = "rebindGroupBox";
            this.rebindGroupBox.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            this.rebindGroupBox.Size = new System.Drawing.Size(828, 50);
            this.rebindGroupBox.TabIndex = 2;
            this.rebindGroupBox.TabStop = false;
            this.rebindGroupBox.Text = "Rebind";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.applyButton, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.detectButton, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.keyComboBox, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.altComboBox, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.shiftComboBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label92, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ctrlComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 10, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 14);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(826, 33);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.applyButton.Location = new System.Drawing.Point(702, 3);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(67, 26);
            this.applyButton.TabIndex = 52;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // detectButton
            // 
            this.detectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.detectButton.Location = new System.Drawing.Point(585, 5);
            this.detectButton.Name = "detectButton";
            this.detectButton.Size = new System.Drawing.Size(54, 22);
            this.detectButton.TabIndex = 50;
            this.detectButton.Text = "Detect";
            this.detectButton.UseVisualStyleBackColor = true;
            // 
            // keyComboBox
            // 
            this.keyComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyComboBox.FormattingEnabled = true;
            this.keyComboBox.Items.AddRange(new object[] {
            "None"});
            this.keyComboBox.Location = new System.Drawing.Point(463, 6);
            this.keyComboBox.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.keyComboBox.Name = "keyComboBox";
            this.keyComboBox.Size = new System.Drawing.Size(104, 21);
            this.keyComboBox.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Key";
            // 
            // altComboBox
            // 
            this.altComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.altComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.altComboBox.FormattingEnabled = true;
            this.altComboBox.Items.AddRange(new object[] {
            "None"});
            this.altComboBox.Location = new System.Drawing.Point(316, 6);
            this.altComboBox.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.altComboBox.Name = "altComboBox";
            this.altComboBox.Size = new System.Drawing.Size(104, 21);
            this.altComboBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Alt";
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Items.AddRange(new object[] {
            "None"});
            this.shiftComboBox.Location = new System.Drawing.Point(175, 6);
            this.shiftComboBox.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(104, 21);
            this.shiftComboBox.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Shift";
            // 
            // label92
            // 
            this.label92.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(3, 10);
            this.label92.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(22, 13);
            this.label92.TabIndex = 43;
            this.label92.Text = "Ctrl";
            // 
            // ctrlComboBox
            // 
            this.ctrlComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctrlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlComboBox.FormattingEnabled = true;
            this.ctrlComboBox.Items.AddRange(new object[] {
            "None"});
            this.ctrlComboBox.Location = new System.Drawing.Point(25, 6);
            this.ctrlComboBox.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.ctrlComboBox.Name = "ctrlComboBox";
            this.ctrlComboBox.Size = new System.Drawing.Size(104, 21);
            this.ctrlComboBox.TabIndex = 40;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelButton.Location = new System.Drawing.Point(775, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(48, 26);
            this.cancelButton.TabIndex = 51;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addManipulatorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addManipulatorButton.Location = new System.Drawing.Point(376, 212);
            this.addManipulatorButton.Name = "addButton";
            this.addManipulatorButton.Size = new System.Drawing.Size(75, 23);
            this.addManipulatorButton.TabIndex = 0;
            this.addManipulatorButton.Text = "Add new";
            this.addManipulatorButton.UseVisualStyleBackColor = true;
            // 
            // SliderManipulatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SliderManipulatorPanel";
            this.Size = new System.Drawing.Size(828, 329);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainGroupBox.ResumeLayout(false);
            this.rebindGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addManipulatorButton;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox rebindGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox ctrlComboBox;
        private System.Windows.Forms.ComboBox keyComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox altComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shiftComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Button detectButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.FlowLayoutPanel manipulatorsPanel;
        private System.Windows.Forms.Button cancelButton;
    }
}
