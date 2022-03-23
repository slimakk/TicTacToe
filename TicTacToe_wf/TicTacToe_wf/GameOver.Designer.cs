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
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(197, 119);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(42, 20);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "label";
            // 
            // nextTurnButton
            // 
            this.nextTurnButton.Location = new System.Drawing.Point(197, 261);
            this.nextTurnButton.Name = "nextTurnButton";
            this.nextTurnButton.Size = new System.Drawing.Size(263, 42);
            this.nextTurnButton.TabIndex = 1;
            this.nextTurnButton.Text = "Next turn choose board size";
            this.nextTurnButton.UseVisualStyleBackColor = true;
            this.nextTurnButton.Click += new System.EventHandler(this.nextTurnButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(263, 56);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nextTurnPlayersButton
            // 
            this.nextTurnPlayersButton.Location = new System.Drawing.Point(197, 210);
            this.nextTurnPlayersButton.Name = "nextTurnPlayersButton";
            this.nextTurnPlayersButton.Size = new System.Drawing.Size(263, 44);
            this.nextTurnPlayersButton.TabIndex = 3;
            this.nextTurnPlayersButton.Text = "Next turn choose players";
            this.nextTurnPlayersButton.UseVisualStyleBackColor = true;
            this.nextTurnPlayersButton.Click += new System.EventHandler(this.nextTurnPlayersButton_Click);
            // 
            // sameTurnButton
            // 
            this.sameTurnButton.Location = new System.Drawing.Point(197, 160);
            this.sameTurnButton.Name = "sameTurnButton";
            this.sameTurnButton.Size = new System.Drawing.Size(263, 44);
            this.sameTurnButton.TabIndex = 4;
            this.sameTurnButton.Text = "Next turn same settings";
            this.sameTurnButton.UseVisualStyleBackColor = true;
            this.sameTurnButton.Click += new System.EventHandler(this.sameTurnButton_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 389);
            this.Controls.Add(this.sameTurnButton);
            this.Controls.Add(this.nextTurnPlayersButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nextTurnButton);
            this.Controls.Add(this.resultLabel);
            this.Name = "GameOver";
            this.Text = "TicTacToe - OOP: Game over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label resultLabel;
        private Button nextTurnButton;
        private Button exitButton;
        private Button nextTurnPlayersButton;
        private Button sameTurnButton;
    }
}