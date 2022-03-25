namespace TicTacToe_wf
{
    partial class GameMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.mainMenu = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.leadrButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.playerMenu = new System.Windows.Forms.Panel();
            this.player_o_Label = new System.Windows.Forms.Label();
            this.player_O = new System.Windows.Forms.TextBox();
            this.player_x_Label = new System.Windows.Forms.Label();
            this.player_x = new System.Windows.Forms.TextBox();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.previousNamesButton = new System.Windows.Forms.Button();
            this.modeSelectButton = new System.Windows.Forms.Button();
            this.gameModeScreen = new System.Windows.Forms.Panel();
            this.backToPlayerButton = new System.Windows.Forms.Button();
            this.customModeButton = new System.Windows.Forms.Button();
            this.normalModeButton = new System.Windows.Forms.Button();
            this.customGameScreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.boardLength = new System.Windows.Forms.TextBox();
            this.backToGMButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainMenu.SuspendLayout();
            this.playerMenu.SuspendLayout();
            this.gameModeScreen.SuspendLayout();
            this.customGameScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.aboutButton);
            this.mainMenu.Controls.Add(this.exitButton);
            this.mainMenu.Controls.Add(this.leadrButton);
            this.mainMenu.Controls.Add(this.playButton);
            this.mainMenu.Location = new System.Drawing.Point(12, 12);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(660, 337);
            this.mainMenu.TabIndex = 0;
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutButton.Location = new System.Drawing.Point(205, 172);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(250, 50);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(205, 228);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(250, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit game";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // leadrButton
            // 
            this.leadrButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leadrButton.Location = new System.Drawing.Point(205, 116);
            this.leadrButton.Name = "leadrButton";
            this.leadrButton.Size = new System.Drawing.Size(250, 50);
            this.leadrButton.TabIndex = 1;
            this.leadrButton.Text = "Leaderboard";
            this.leadrButton.UseVisualStyleBackColor = true;
            this.leadrButton.Click += new System.EventHandler(this.leadrButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playButton.Location = new System.Drawing.Point(205, 60);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(250, 50);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playerMenu
            // 
            this.playerMenu.Controls.Add(this.player_o_Label);
            this.playerMenu.Controls.Add(this.player_O);
            this.playerMenu.Controls.Add(this.player_x_Label);
            this.playerMenu.Controls.Add(this.player_x);
            this.playerMenu.Controls.Add(this.backToMenuButton);
            this.playerMenu.Controls.Add(this.previousNamesButton);
            this.playerMenu.Controls.Add(this.modeSelectButton);
            this.playerMenu.Location = new System.Drawing.Point(12, 12);
            this.playerMenu.Name = "playerMenu";
            this.playerMenu.Size = new System.Drawing.Size(660, 337);
            this.playerMenu.TabIndex = 1;
            // 
            // player_o_Label
            // 
            this.player_o_Label.AutoSize = true;
            this.player_o_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player_o_Label.Location = new System.Drawing.Point(205, 36);
            this.player_o_Label.Name = "player_o_Label";
            this.player_o_Label.Size = new System.Drawing.Size(64, 20);
            this.player_o_Label.TabIndex = 6;
            this.player_o_Label.Text = "Player O";
            // 
            // player_O
            // 
            this.player_O.Location = new System.Drawing.Point(205, 59);
            this.player_O.Name = "player_O";
            this.player_O.Size = new System.Drawing.Size(250, 23);
            this.player_O.TabIndex = 5;
            this.player_O.Validating += new System.ComponentModel.CancelEventHandler(this.player_O_Validating);
            // 
            // player_x_Label
            // 
            this.player_x_Label.AutoSize = true;
            this.player_x_Label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player_x_Label.Location = new System.Drawing.Point(205, 88);
            this.player_x_Label.Name = "player_x_Label";
            this.player_x_Label.Size = new System.Drawing.Size(62, 20);
            this.player_x_Label.TabIndex = 4;
            this.player_x_Label.Text = "Player X";
            // 
            // player_x
            // 
            this.player_x.Location = new System.Drawing.Point(205, 111);
            this.player_x.Name = "player_x";
            this.player_x.Size = new System.Drawing.Size(250, 23);
            this.player_x.TabIndex = 3;
            this.player_x.Validating += new System.ComponentModel.CancelEventHandler(this.player_x_Validating);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToMenuButton.Location = new System.Drawing.Point(205, 252);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(250, 50);
            this.backToMenuButton.TabIndex = 2;
            this.backToMenuButton.Text = "Back to main menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // previousNamesButton
            // 
            this.previousNamesButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previousNamesButton.Location = new System.Drawing.Point(205, 196);
            this.previousNamesButton.Name = "previousNamesButton";
            this.previousNamesButton.Size = new System.Drawing.Size(250, 50);
            this.previousNamesButton.TabIndex = 1;
            this.previousNamesButton.Text = "Choose previous names";
            this.previousNamesButton.UseVisualStyleBackColor = true;
            this.previousNamesButton.Click += new System.EventHandler(this.previousNamesButton_Click);
            // 
            // modeSelectButton
            // 
            this.modeSelectButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modeSelectButton.Location = new System.Drawing.Point(205, 140);
            this.modeSelectButton.Name = "modeSelectButton";
            this.modeSelectButton.Size = new System.Drawing.Size(250, 50);
            this.modeSelectButton.TabIndex = 0;
            this.modeSelectButton.Text = "Play";
            this.modeSelectButton.UseVisualStyleBackColor = true;
            this.modeSelectButton.Click += new System.EventHandler(this.modeSelectButton_Click);
            // 
            // gameModeScreen
            // 
            this.gameModeScreen.Controls.Add(this.backToPlayerButton);
            this.gameModeScreen.Controls.Add(this.customModeButton);
            this.gameModeScreen.Controls.Add(this.normalModeButton);
            this.gameModeScreen.Location = new System.Drawing.Point(12, 12);
            this.gameModeScreen.Name = "gameModeScreen";
            this.gameModeScreen.Size = new System.Drawing.Size(660, 337);
            this.gameModeScreen.TabIndex = 2;
            // 
            // backToPlayerButton
            // 
            this.backToPlayerButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToPlayerButton.Location = new System.Drawing.Point(205, 202);
            this.backToPlayerButton.Name = "backToPlayerButton";
            this.backToPlayerButton.Size = new System.Drawing.Size(250, 50);
            this.backToPlayerButton.TabIndex = 2;
            this.backToPlayerButton.Text = "Back";
            this.backToPlayerButton.UseVisualStyleBackColor = true;
            this.backToPlayerButton.Click += new System.EventHandler(this.backToPlayerButton_Click);
            // 
            // customModeButton
            // 
            this.customModeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customModeButton.Location = new System.Drawing.Point(205, 146);
            this.customModeButton.Name = "customModeButton";
            this.customModeButton.Size = new System.Drawing.Size(250, 50);
            this.customModeButton.TabIndex = 1;
            this.customModeButton.Text = "Custom size";
            this.customModeButton.UseVisualStyleBackColor = true;
            this.customModeButton.Click += new System.EventHandler(this.customModeButton_Click);
            // 
            // normalModeButton
            // 
            this.normalModeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.normalModeButton.Location = new System.Drawing.Point(205, 90);
            this.normalModeButton.Name = "normalModeButton";
            this.normalModeButton.Size = new System.Drawing.Size(250, 50);
            this.normalModeButton.TabIndex = 0;
            this.normalModeButton.Text = "Normal size";
            this.normalModeButton.UseVisualStyleBackColor = true;
            this.normalModeButton.Click += new System.EventHandler(this.normalModeButton_Click);
            // 
            // customGameScreen
            // 
            this.customGameScreen.Controls.Add(this.label1);
            this.customGameScreen.Controls.Add(this.boardLength);
            this.customGameScreen.Controls.Add(this.backToGMButton);
            this.customGameScreen.Controls.Add(this.okButton);
            this.customGameScreen.Location = new System.Drawing.Point(12, 12);
            this.customGameScreen.Name = "customGameScreen";
            this.customGameScreen.Size = new System.Drawing.Size(660, 337);
            this.customGameScreen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(205, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of boxes:";
            // 
            // boardLength
            // 
            this.boardLength.Location = new System.Drawing.Point(205, 117);
            this.boardLength.Name = "boardLength";
            this.boardLength.Size = new System.Drawing.Size(250, 23);
            this.boardLength.TabIndex = 3;
            this.boardLength.Validating += new System.ComponentModel.CancelEventHandler(this.boardLength_Validating);
            // 
            // backToGMButton
            // 
            this.backToGMButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToGMButton.Location = new System.Drawing.Point(205, 202);
            this.backToGMButton.Name = "backToGMButton";
            this.backToGMButton.Size = new System.Drawing.Size(250, 50);
            this.backToGMButton.TabIndex = 2;
            this.backToGMButton.Text = "Back";
            this.backToGMButton.UseVisualStyleBackColor = true;
            this.backToGMButton.Click += new System.EventHandler(this.backToGMButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okButton.Location = new System.Drawing.Point(205, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(250, 50);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Play";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.playerMenu);
            this.Controls.Add(this.gameModeScreen);
            this.Controls.Add(this.customGameScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe - Menu";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.mainMenu.ResumeLayout(false);
            this.playerMenu.ResumeLayout(false);
            this.playerMenu.PerformLayout();
            this.gameModeScreen.ResumeLayout(false);
            this.customGameScreen.ResumeLayout(false);
            this.customGameScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainMenu;
        private Button exitButton;
        private Button leadrButton;
        private Button playButton;
        private Panel playerMenu;
        private Button backToMenuButton;
        private Button previousNamesButton;
        private Button modeSelectButton;
        private TextBox player_x;
        private Label player_o_Label;
        private TextBox player_O;
        private Label player_x_Label;
        private Panel gameModeScreen;
        private Button backToPlayerButton;
        private Button customModeButton;
        private Button normalModeButton;
        private Panel customGameScreen;
        private Label label1;
        private TextBox boardLength;
        private Button backToGMButton;
        private Button okButton;
        private ErrorProvider errorProvider;
        private Button aboutButton;
    }
}