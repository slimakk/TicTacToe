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
    public partial class Leaderboard_form : Form
    {
        public Leaderboard_form()
        {
            InitializeComponent();
        }

        private void Leaderboard_form_Load(object sender, EventArgs e)
        {
            //setting up listview
            leaderboard.View = View.Details;
            leaderboard.Columns.Add("Name");
            leaderboard.Columns.Add("Wins");
            leaderboard.Columns[0].Width = this.leaderboard.Width / 2;
            //filling and sorting listview
            for(int i = 1; i <= 4; i++)
            {
                leaderboard.Items.Add(new ListViewItem(new string[] { String.Format("Meno {0}", i.ToString()), i.ToString()}));
            }
            leaderboard.Sorting = SortOrder.Descending;
        }

        private void backButton_Click(object sender, EventArgs e)//Self-explanatory
        {
            Hide();
            TicTacToe menu = new TicTacToe();
            menu.ShowDialog();
        }
        private void Leaderboard_form_Closed(object sender, FormClosedEventArgs e) //should close but doesnt work
        {
            Application.Exit();
        }
    }
}
