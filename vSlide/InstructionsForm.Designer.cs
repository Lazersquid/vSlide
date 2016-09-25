namespace vSlide
{
    partial class InstructionsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.instructionsTabControl = new System.Windows.Forms.TabControl();
            this.introductionTabPage = new System.Windows.Forms.TabPage();
            this.instructionsInfoLabel = new System.Windows.Forms.Label();
            this.advancedTabPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.instructionsTabControl.SuspendLayout();
            this.introductionTabPage.SuspendLayout();
            this.advancedTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 247);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // instructionsTabControl
            // 
            this.instructionsTabControl.Controls.Add(this.introductionTabPage);
            this.instructionsTabControl.Controls.Add(this.advancedTabPage);
            this.instructionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.instructionsTabControl.Name = "instructionsTabControl";
            this.instructionsTabControl.SelectedIndex = 0;
            this.instructionsTabControl.Size = new System.Drawing.Size(514, 288);
            this.instructionsTabControl.TabIndex = 6;
            // 
            // introductionTabPage
            // 
            this.introductionTabPage.Controls.Add(this.instructionsInfoLabel);
            this.introductionTabPage.Location = new System.Drawing.Point(4, 22);
            this.introductionTabPage.Name = "introductionTabPage";
            this.introductionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.introductionTabPage.Size = new System.Drawing.Size(506, 262);
            this.introductionTabPage.TabIndex = 0;
            this.introductionTabPage.Text = "Introduction";
            this.introductionTabPage.UseVisualStyleBackColor = true;
            // 
            // instructionsInfoLabel
            // 
            this.instructionsInfoLabel.AutoSize = true;
            this.instructionsInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsInfoLabel.Location = new System.Drawing.Point(6, 8);
            this.instructionsInfoLabel.Name = "instructionsInfoLabel";
            this.instructionsInfoLabel.Size = new System.Drawing.Size(496, 247);
            this.instructionsInfoLabel.TabIndex = 7;
            this.instructionsInfoLabel.Text = resources.GetString("instructionsInfoLabel.Text");
            // 
            // advancedTabPage
            // 
            this.advancedTabPage.Controls.Add(this.label1);
            this.advancedTabPage.Location = new System.Drawing.Point(4, 22);
            this.advancedTabPage.Name = "advancedTabPage";
            this.advancedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.advancedTabPage.Size = new System.Drawing.Size(506, 262);
            this.advancedTabPage.TabIndex = 1;
            this.advancedTabPage.Text = "Advanced";
            this.advancedTabPage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "You can mess with the settings to understand them and then just revert to default" +
    ".\r\nFeel free to contact me if you need help";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.instructionsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "InstructionsForm";
            this.Text = "vSlide - Instructions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstructionsForm_FormClosing);
            this.instructionsTabControl.ResumeLayout(false);
            this.introductionTabPage.ResumeLayout(false);
            this.introductionTabPage.PerformLayout();
            this.advancedTabPage.ResumeLayout(false);
            this.advancedTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl instructionsTabControl;
        private System.Windows.Forms.TabPage introductionTabPage;
        private System.Windows.Forms.Label instructionsInfoLabel;
        private System.Windows.Forms.TabPage advancedTabPage;
        private System.Windows.Forms.Label label5;
    }
}