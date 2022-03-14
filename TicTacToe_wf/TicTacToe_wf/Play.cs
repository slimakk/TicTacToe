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
        TextBox textBox = new TextBox();
        public Play()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            TicTacToe menu = new TicTacToe();
            menu.ShowDialog();
        }

        private void normalGameButton_Click(object sender, EventArgs e)
        {

        }

        private void customGameButton_Click(object sender, EventArgs e)
        {

            normalGameButton.Visible = false;
            customGameButton.Visible = false;
            backButton.Visible = false;

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
        private void okButton_Click(object sender, EventArgs e)
        {
            SizeOfBoard = Int32.Parse(textBox.Text);
            Hide();
            Board board = new Board(SizeOfBoard);
            board.generateBoard();
            board.ShowDialog();

        }

        private void Play_FormClosed(object sender, FormClosedEventArgs e) //shuts off program when "krizik" is pressed
        {
            Application.Exit();
        }
    }
}
