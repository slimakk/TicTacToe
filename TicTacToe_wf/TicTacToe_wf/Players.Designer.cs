namespace TicTacToe_wf
{
    partial class Players
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
            this.playButton = new System.Windows.Forms.Button();
            this.playerO = new System.Windows.Forms.TextBox();
            this.playerX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previousNamesButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(266, 223);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(217, 60);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playerO
            // 
            this.playerO.Location = new System.Drawing.Point(266, 106);
            this.playerO.Multiline = true;
            this.playerO.Name = "playerO";
            this.playerO.Size = new System.Drawing.Size(217, 27);
            this.playerO.TabIndex = 2;
            // 
            // playerX
            // 
            this.playerX.Location = new System.Drawing.Point(266, 170);
            this.playerX.Name = "playerX";
            this.playerX.Size = new System.Drawing.Size(217, 27);
            this.playerX.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player with O";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player with X";
            // 
            // previousNamesButton
            // 
            this.previousNamesButton.Location = new System.Drawing.Point(266, 298);
            this.previousNamesButton.Name = "previousNamesButton";
            this.previousNamesButton.Size = new System.Drawing.Size(217, 55);
            this.previousNamesButton.TabIndex = 6;
            this.previousNamesButton.Text = "Choose previous names";
            this.previousNamesButton.UseVisualStyleBackColor = true;
            this.previousNamesButton.Click += new System.EventHandler(this.previousNamesButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(266, 368);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(217, 55);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back to menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 481);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.previousNamesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerX);
            this.Controls.Add(this.playerO);
            this.Controls.Add(this.playButton);
            this.Name = "Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe - OOP: Players";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Players_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button playButton;
        private TextBox playerO;
        private TextBox playerX;
        private Label label1;
        private Label label2;
        private Button previousNamesButton;
        private Button backButton;
    }
}