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
    public partial class GameOver : Form
    {
        private string winner;
        private int turns;
        private string player_o;
        private string player_x;
        private int SizeOfBoard;
        public GameOver(string winner, int turns, string result, string player_o, string player_x,int size)
        {
            InitializeComponent();
            this.player_o = player_o;
            this.player_x = player_x;
            this.winner = winner;
            this.SizeOfBoard = size;
            if (result == "Remiza")
                this.resultLabel.Text = $"{result} nobody wins this time :(";
            else
                this.resultLabel.Text = $"{result} for {winner} after {turns} turns. CONGRATS viii";
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            Hide();
            Play play = new Play(player_o, player_x);
            play.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextTurnPlayersButton_Click(object sender, EventArgs e)
        {
            Hide();
            Players players = new Players();
            players.ShowDialog();
        }

        private void sameTurnButton_Click(object sender, EventArgs e)
        {
            Hide();
            Board board = new Board(SizeOfBoard, player_o, player_x);
            board.generateBoard();
            board.ShowDialog();
        }
    }
}
