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
        //private Panel[] screens = new Panel[4];
        private Database dat = new Database();
        private string playerO = "";
        private string playerX = "";
        private int SizeOfBoard = 3;
        public GameMenu()
        {
            InitializeComponent();
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
            screens.Add(mainMenu);
            screens.Add(playerMenu);
            screens.Add(gameModeScreen);
            screens.Add(customGameScreen);
            /*screens[0] = mainMenu;
            screens[1] = playerMenu;
            screens[2] = gameModeScreen;
            screens[3] = customGameScreen;*/
            screens[0].BringToFront();
        }
        //First screen - Main Menu
        private void playButton_Click(object sender, EventArgs e)
        {
            screens[1].BringToFront();
        }

        private void leadrButton_Click(object sender, EventArgs e)
        {
            Hide();
            var leader = new Leaderboard_form();
            leader.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Second screen - player menu
        private void modeSelectButton_Click(object sender, EventArgs e)
        {
            playerO = player_O.Text;
            playerX = player_x.Text;
            screens[2].BringToFront();
        }

        private void previousNamesButton_Click(object sender, EventArgs e)
        {
            string[] players = dat.LoadPrevious();
            playerO = players[0];
            playerX = players[1];
            screens[2].BringToFront();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            screens[0].BringToFront();
        }
        //Thrid screen - gamemode menu
        private void normalModeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Board board = new Board(SizeOfBoard, playerO, playerX);
            board.generateBoard();
            board.ShowDialog();
        }

        private void customModeButton_Click(object sender, EventArgs e)
        {
            screens[3].BringToFront();
        }

        private void backToPlayerButton_Click(object sender, EventArgs e)
        {
            screens[1].BringToFront();
        }
        //Forth screen - custom game menu
        private void okButton_Click(object sender, EventArgs e)
        {
            SizeOfBoard = int.Parse(boardLength.Text);
            Hide();
            Board board = new Board(SizeOfBoard, playerO, playerX);
            board.generateBoard();
            board.ShowDialog();
        }

        private void backToGMButton_Click(object sender, EventArgs e)
        {
            screens[2].BringToFront();
        }
    }
}
