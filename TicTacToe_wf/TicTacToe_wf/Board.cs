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
        public Board(int Size)
        {
            InitializeComponent();
            this.size = Size;
        }
        public void generateBoard()
        {
            /*for (int i = 0; i < size; i++)
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
            }*/
            FlowLayoutPanel board = new FlowLayoutPanel();
            board.Size = new Size(65 * size, 65 * size);
            board.FlowDirection = FlowDirection.LeftToRight;
            board.Left = (this.ClientSize.Width - board.Width)/2;
            board.Top = (this.ClientSize.Height - board.Height)/2;
            board.Anchor = AnchorStyles.None;
            for (int i = 0; i < size*size; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(61, 61);
                btn.Margin = new Padding(2, 2, 2, 2);
                btn.Click += gameButtton_Click;
                board.Controls.Add(btn);
            }
            this.Controls.Add(board);
        }
        private void gameButtton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Marek je gay");
        }

    }
}
