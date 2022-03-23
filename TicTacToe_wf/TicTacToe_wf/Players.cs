using System;
using System.IO;
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
    public partial class Players : Form
    {

        public Players() //constructor
        {
            InitializeComponent();

        }

        private void backButton_Click(object sender, EventArgs e) //shows main menu window
        {
            Hide();
            TicTacToe menu = new TicTacToe();
            menu.ShowDialog();
        }

        private void previousNamesButton_Click(object sender, EventArgs e) //sets names from previous game
        {
            string[] players = File.ReadAllText("previous.txt").Split();
            Hide();
            Play play = new Play(players[0], players[1]);
            play.ShowDialog();

        }

        private void playButton_Click(object sender, EventArgs e) //sets names that are typed in text boxes
        {
            Hide();
            Play play = new Play(playerO.Text, playerX.Text);
            play.ShowDialog();

        }

        private void Players_FormClosed(object sender, FormClosedEventArgs e) //shuts off program
        {
            Application.Exit();
        }
    }
}
