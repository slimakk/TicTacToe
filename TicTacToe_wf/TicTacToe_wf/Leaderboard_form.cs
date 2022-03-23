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
        private Database dat = new Database();
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
            //loading and sorting dictionary with LINQ
            var boardItems = from entry in dat.LoadFromLeaderboard() orderby entry.Value descending select entry;
            //filling up listview with top 10 players
            for(int i = 0; i < 10; i++)
            {
                var player = boardItems.ElementAt(i);
                leaderboard.Items.Add(new ListViewItem(new string[] {player.Key,player.Value.ToString()}));
            }
        }

        private void backButton_Click(object sender, EventArgs e)//Self-explanatory
        {
            Hide();
            TicTacToe menu = new TicTacToe();
            menu.ShowDialog();
        }
        private void Leaderboard_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
