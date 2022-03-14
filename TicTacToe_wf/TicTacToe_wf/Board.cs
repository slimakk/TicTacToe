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
    public partial class Board : Form
    {
        private int size;
        private bool turn;
        private String[,] board;
        public Board(int Size)
        {
            InitializeComponent();
            this.size = Size;
        }
        public void generateBoard()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button button = new Button();
                    button.Left = i * (50);
                    button.Top = j * (50);
                    button.Width = (50);
                    button.Height = (50);
                    this.Controls.Add(button);
                    button.Click += gameButtton_Click;
                }
            }  
        }
        private void checkWinner()
        {
            board = new String[size,size];
            int i = 0; int j = 0;
            bool diagonal1 = true;bool diagonal2 = true;
            foreach(Button button in this.Controls) 
            {
                board[i, j] = button.Text; i++;
                if (i == size)
                {
                    i = 0; j++;
                }
                else if (j == size)
                {
                    j = 0;
                }
            } //changes buttton to string 2d array

            for (int row = 0;row<size-1;row++)
            {
                for (int col = 0;col<size-1;col++) //check first diagonal
                {
                    if (board[row, col] != board[row+1, col+1])
                    {
                        diagonal1 = false;
                    }
                }
                for (int col = size-1; col > 0; col--) //check second diagonal
                {
                    if (board[row, col] != board[row + 1, col-1])
                    {
                        diagonal2 = false;
                    }
                }
            }
            MessageBox.Show($"{diagonal2}");
        }
        private void gameButtton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
                button.Text = "X";
            else
                button.Text = "O";

            button.Enabled = false;
            turn = !turn;
            checkWinner();
        }

        private void Board_FormClosed(object sender, FormClosedEventArgs e) //shuts off program when "krizik" is pressed
        {
            Application.Exit();
        }
    }
}
