namespace TicTacToe_wf
{
    partial class GameOver
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.nextTurnButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nextTurnPlayersButton = new System.Windows.Forms.Button();
            this.sameTurnButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.newGameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(12, 64);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(42, 20);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "label";
            // 
            // nextTurnButton
            // 
            this.nextTurnButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextTurnButton.Location = new System.Drawing.Point(392, 140);
            this.nextTurnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextTurnButton.Name = "nextTurnButton";
            this.nextTurnButton.Size = new System.Drawing.Size(180, 35);
            this.nextTurnButton.TabIndex = 1;
            this.nextTurnButton.Text = "New board size";
            this.nextTurnButton.UseVisualStyleBackColor = true;
            this.nextTurnButton.Click += new System.EventHandler(this.nextTurnButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(168, 200);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(250, 35);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Quit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nextTurnPlayersButton
            // 
            this.nextTurnPlayersButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextTurnPlayersButton.Location = new System.Drawing.Point(203, 140);
            this.nextTurnPlayersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextTurnPlayersButton.Name = "nextTurnPlayersButton";
            this.nextTurnPlayersButton.Size = new System.Drawing.Size(180, 35);
            this.nextTurnPlayersButton.TabIndex = 3;
            this.nextTurnPlayersButton.Text = "New players";
            this.nextTurnPlayersButton.UseVisualStyleBackColor = true;
            this.nextTurnPlayersButton.Click += new System.EventHandler(this.nextTurnPlayersButton_Click);
            // 
            // sameTurnButton
            // 
            this.sameTurnButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sameTurnButton.Location = new System.Drawing.Point(12, 140);
            this.sameTurnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sameTurnButton.Name = "sameTurnButton";
            this.sameTurnButton.Size = new System.Drawing.Size(180, 35);
            this.sameTurnButton.TabIndex = 4;
            this.sameTurnButton.Text = "Same settings";
            this.sameTurnButton.UseVisualStyleBackColor = true;
            this.sameTurnButton.Click += new System.EventHandler(this.sameTurnButton_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.Location = new System.Drawing.Point(236, 9);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(114, 28);
            this.gameOverLabel.TabIndex = 5;
            this.gameOverLabel.Text = "Game over!";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newGameLabel
            // 
            this.newGameLabel.AutoSize = true;
            this.newGameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newGameLabel.Location = new System.Drawing.Point(12, 111);
            this.newGameLabel.Name = "newGameLabel";
            this.newGameLabel.Size = new System.Drawing.Size(84, 20);
            this.newGameLabel.TabIndex = 6;
            this.newGameLabel.Text = "New game:";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.newGameLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.sameTurnButton);
            this.Controls.Add(this.nextTurnPlayersButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nextTurnButton);
            this.Controls.Add(this.resultLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label resultLabel;
        private Button nextTurnButton;
        private Button exitButton;
        private Button nextTurnPlayersButton;
        private Button sameTurnButton;
        private Label gameOverLabel;
        private Label newGameLabel;
    }
}