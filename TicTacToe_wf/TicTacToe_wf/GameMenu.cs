using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_wf
{
    public partial class GameMenu : Form
    {
        private List<Panel> screens = new List<Panel>();
        private Database dat = new Database();
        private ValidInput check = new ValidInput();
        private string playerO = "";
        private string playerX = "";
        private int SizeOfBoard = 3;
        private int index = 0;
        private string errorMessage = "";
        public GameMenu()//Default constructor
        {
            InitializeComponent();
        }
        public GameMenu(string playerO, string playerX,int index)//Constructor used for starting the game over
        {
            InitializeComponent();
            this.playerO = playerO; this.playerX = playerX; this.index = index;
        }
        //Loading form and adding screens to List + setting main menu as default startup screen
        private void GameMenu_Load(object sender, EventArgs e)
        {
            screens.Add(mainMenu);
            screens.Add(playerMenu);
            screens.Add(gameModeScreen);
            screens.Add(customGameScreen);
            screens[index].BringToFront();
        }
        //First screen - Main Menu

        //Switching to player menu
        private void playButton_Click(object sender, EventArgs e)
        {
            screens[1].BringToFront();
        }
        //Opening leaderboard form
        private void leadrButton_Click(object sender, EventArgs e)
        {
            Hide();
            var leader = new Leaderboard_form();
            leader.ShowDialog();
        }
        private void aboutButton_Click(object sender, EventArgs e)
        {
            string about = "TicTacToe Game\nBy slimakk & sedemto ©2022";
            MessageBoxButtons okButton = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(about,"About", okButton);

        }
        //Closing the game
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Second screen - player menu

        //Setting up player names and switching to game mode selection
        private void modeSelectButton_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                playerO = player_O.Text;
                playerX = player_x.Text;
                screens[2].BringToFront();
            }
        }
        //Setting up player names from previous game and switching to game mode selection
        private void previousNamesButton_Click(object sender, EventArgs e)
        {
            string[] players = dat.LoadPrevious();
            playerO = players[0];
            playerX = players[1];
            screens[2].BringToFront();
        }
        //Switching back to main menu
        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            screens[0].BringToFront();
        }
        //Checking if entered names are valid names
        private void player_O_Validating(object sender, CancelEventArgs e)
        {
            if(!check.ValidName(player_O.Text,out errorMessage))
            {
                e.Cancel = true;
                errorProvider.SetError(player_O, errorMessage);
            }
        }
        private void player_O_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(player_O, "");
        }
        private void player_x_Validating(object sender, CancelEventArgs e)
        {
            if (!check.ValidName(player_x.Text, out errorMessage))
            {
                e.Cancel = true;
                errorProvider.SetError(player_x, errorMessage);
            }
        }
        private void player_x_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(player_x, "");
        }

        //Thrid screen - gamemode menu

        //Starting normal game - 3x3 layout
        private void normalModeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Board board = new Board(SizeOfBoard, playerO, playerX);
            board.generateBoard();
            board.ShowDialog();
        }
        //Switching to custom game selection
        private void customModeButton_Click(object sender, EventArgs e)
        {
            screens[3].BringToFront();
        }
        //Switching back to player menu
        private void backToPlayerButton_Click(object sender, EventArgs e)
        {
            screens[1].BringToFront();
        }
        //Forth screen - custom game menu

        //Starting custom game with user-defined layout
        private void okButton_Click(object sender, EventArgs e)
        {
            SizeOfBoard = Decimal.ToInt32(boardLength.Value);
            Hide();
            Board board = new Board(SizeOfBoard, playerO, playerX);
            board.generateBoard();
            board.ShowDialog();
        }
        //Switching back to game mode selection
        private void backToGMButton_Click(object sender, EventArgs e)
        {
            screens[2].BringToFront();
        }
    }
}
