﻿namespace myFirstVJoyFeeder
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
            this.instructionsInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionsInfoLabel
            // 
            this.instructionsInfoLabel.AutoSize = true;
            this.instructionsInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsInfoLabel.Location = new System.Drawing.Point(27, 34);
            this.instructionsInfoLabel.Name = "instructionsInfoLabel";
            this.instructionsInfoLabel.Size = new System.Drawing.Size(451, 195);
            this.instructionsInfoLabel.TabIndex = 0;
            this.instructionsInfoLabel.Text = resources.GetString("instructionsInfoLabel.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 208);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Small Introduction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Advanced:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Feel free to contact me if you are stuck or need help.\r\nThank you for using vSlid" +
    "e!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Note:\r\nMessing with the settings won\'t break the programm or the driver,\r\nbut wil" +
    "l help you at understanding this programm better!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructionsInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "InstructionsForm";
            this.Text = "vSlide - Instructions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstructionsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}