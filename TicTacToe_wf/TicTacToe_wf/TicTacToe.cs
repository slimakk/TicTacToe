namespace TicTacToe_wf
{
    public partial class TicTacToe : Form
    {
        public TicTacToe() //constructor
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e) //shows Players window
        {
            Hide();
            Players play = new Players();
            play.ShowDialog();
        }

        private void endButton_Click(object sender, EventArgs e) //shuts off program
        {
            Application.Exit();
        }

        private void leaderboardButton_Click(object sender, EventArgs e) //shows Leaderboard window
        {
            Hide();
            var leader = new Leaderboard_form();
            leader.ShowDialog();
        }

        private void TicTacToe_FormClosed(object sender, FormClosedEventArgs e) //shuts off program
        {
            Application.Exit();
        }
    }
}