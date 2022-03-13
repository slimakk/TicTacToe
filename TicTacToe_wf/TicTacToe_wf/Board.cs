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
        private void gameButtton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Marek je gay");
        }

    }
}
