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
        private string player_o;
        private string player_x;
        private int size;
        private bool turn ;
        private String[,] board_;
        private FlowLayoutPanel board = new FlowLayoutPanel();
        private int numberOfTurns = 0;
        private string currentPlayer;
        private bool tie = false;
        public Board(int Size,string player_o, string player_x)
        {
            InitializeComponent();
            this.player_o = player_o;
            this.player_x = player_x;
            this.size = Size;
            this.board_ = new String[size, size];
            var random = new Random();
            this.turn = random.Next(2) == 1;
            if (turn)
                this.currentPlayer = player_x;
            else
                this.currentPlayer = player_o;
        }
        public void generateBoard()
        {

            //Setting up flowlayout panel
            board.Size = new Size(65 * size, 65 * size);
            board.FlowDirection = FlowDirection.LeftToRight;
            board.Left = (this.ClientSize.Width - board.Width) / 2;
            board.Top = (this.ClientSize.Height - board.Height) / 2;
            board.Anchor = AnchorStyles.None;
            for (int i = 0; i < size * size; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(61, 61);
                btn.Margin = new Padding(2, 2, 2, 2);
                btn.Click += gameButtton_Click;
                board.Controls.Add(btn);
            }
            this.Controls.Add(board);
        }
        private bool checkWinner()
        {
            int i = 0; int j = 0;
            bool diagonal1 = true; bool diagonal2 = true; bool rows = true; bool cols = true; bool empty = true;
            foreach (Button button in board.Controls.OfType<Button>())
            {
                if (button.Text == "")
                    empty = false;

                board_[j, i] = button.Text; i++;
                if (i == size)
                {
                    i = 0; j++;
                }
                else if (j == size)
                {
                    j = 0;
                }
            } //changes butttons to string 2d array

            for (int p = 0; p < size - 1; p++)
            {
                if (board_[p, p] != board_[p + 1, p + 1] || board_[p, p] == "")
                {
                    diagonal1 = false;
                }
            } //diagonal 1

            for (int p = size - 1; p > 0; p--)
            {
                if (board_[size - 1 - p, p] != board_[size - p, p - 1] || board_[size - 1 - p, p] == "")
                {
                    diagonal2 = false;
                }
            } //diagonal 2

            if (diagonal1 || diagonal2)
            {
                //MessageBox.Show($"VYHRAAA a {numberOfTurns}");
                disableButtons();
                return true;
            }
            for(int row = 0; row < size; row++)
            {
                for(int col = 0; col < size-1; col++)
                {
                    if (board_[row, col] != board_[row, col + 1] || board_[row,col] == "")
                    {
                        rows = false;
                    } //rows
                    if (board_[col, row] != board_[col +1, row] || board_[col, row] == "")
                    {
                        cols = false;
                    } //cols
                }
                if (rows || cols)
                {
                    disableButtons();
                    //MessageBox.Show($"VYHRAAA a {numberOfTurns} a {currentPlayer}"); // TREBA DOROBIT
                    return true;
                }
                if (empty && !diagonal1 && !diagonal2 && !rows && !cols)
                {
                    //MessageBox.Show("REMIZAA"); //TREBA DOROBIT
                    tie = true;
                    return true;
                }
                rows = true;cols = true;
            } //rows and cols
            return false;

        }
        private void disableButtons()
        {
            foreach(Button button in board.Controls.OfType<Button>())
            {
                button.Enabled = false;
            }
        }
        private void gameButtton_Click(object sender, EventArgs e)
        {
            numberOfTurns += 1;
            Button button = (Button)sender;
            if (turn)
            {
                this.currentPlayer = player_x;
                button.Text = "X";
            }
            else
            {
                this.currentPlayer = player_o;
                button.Text = "O";
            }

            button.Enabled = false;
            turn = !turn;
            if (checkWinner())
            {
                File.WriteAllText("previous.txt", $"{player_o} {player_x}");
                if (tie)
                {
                    GameOver gameOver = new GameOver(currentPlayer, numberOfTurns, "Remiza", player_o, player_x, size);
                    gameOver.ShowDialog();
                }

                else
                {
                    GameOver gameOver = new GameOver(currentPlayer, numberOfTurns, "Vyhra", player_o, player_x, size);
                    gameOver.ShowDialog();
                }
            }

            
        }

        private void Board_FormClosed(object sender, FormClosedEventArgs e) //shuts off program when "krizik" is pressed
        {
            Application.Exit();
        }
    }
}
