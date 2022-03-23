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
    public partial class Play : Form
    {
        private int SizeOfBoard = 3;
        private string player_o;
        private string player_x;
        TextBox textBox = new TextBox();
        public Play(string player_o, string player_x) //constructor
        {
            this.player_o = player_o;
            this.player_x = player_x;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e) //shows Players window
        {
            Hide();
            Players players = new Players();
            players.ShowDialog();
        }

        private void normalGameButton_Click(object sender, EventArgs e) //start game with 3x3 layout
        {
            Hide();
            Board board = new Board(SizeOfBoard, player_o, player_x);
            board.generateBoard();
            board.ShowDialog();
        }

        private void customGameButton_Click(object sender, EventArgs e) //layout for custom game
        {
            //hides buttons
            normalGameButton.Visible = false;
            customGameButton.Visible = false;
            backButton.Visible = false;
            //generates new buttons NEEDS SOME WORK
            Label getNumber = new Label();
            Button button = new Button();   
            this.Controls.Add(getNumber);
            this.Controls.Add(textBox);
            this.Controls.Add(button);

            getNumber.AutoSize = true;
            getNumber.Location = new Point(100, 100);
            getNumber.Text = "Type a number:";
            textBox.Location = new Point(250, 100);
            textBox.Size = new Size(100,20);
            button.Location = new Point(350, 100);
            button.Click += okButton_Click;
 

        }
        private void okButton_Click(object sender, EventArgs e)//generates board with given number
        {
            SizeOfBoard = Int32.Parse(textBox.Text);
            Hide();
            Board board = new Board(SizeOfBoard,player_o,player_x);
            board.generateBoard();
            board.ShowDialog();

        }

        private void Play_FormClosed(object sender, FormClosedEventArgs e) //shuts off program
        {
            Application.Exit();
        }
    }
}
