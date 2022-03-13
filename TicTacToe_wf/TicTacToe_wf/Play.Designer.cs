﻿namespace TicTacToe_wf
{
    partial class Play
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
            this.backButton = new System.Windows.Forms.Button();
            this.normalGameButton = new System.Windows.Forms.Button();
            this.customGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(203, 299);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(323, 161);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // normalGameButton
            // 
            this.normalGameButton.Location = new System.Drawing.Point(201, 116);
            this.normalGameButton.Name = "normalGameButton";
            this.normalGameButton.Size = new System.Drawing.Size(325, 70);
            this.normalGameButton.TabIndex = 1;
            this.normalGameButton.Text = "3x3";
            this.normalGameButton.UseVisualStyleBackColor = true;
            this.normalGameButton.Click += new System.EventHandler(this.normalGameButton_Click);
            // 
            // customGameButton
            // 
            this.customGameButton.Location = new System.Drawing.Point(205, 209);
            this.customGameButton.Name = "customGameButton";
            this.customGameButton.Size = new System.Drawing.Size(323, 59);
            this.customGameButton.TabIndex = 2;
            this.customGameButton.Text = "Custom";
            this.customGameButton.UseVisualStyleBackColor = true;
            this.customGameButton.Click += new System.EventHandler(this.customGameButton_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.customGameButton);
            this.Controls.Add(this.normalGameButton);
            this.Controls.Add(this.backButton);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.ResumeLayout(false);

        }

        #endregion

        private Button backButton;
        private Button normalGameButton;
        private Button customGameButton;
        private TextBox textBox1;
    }
}