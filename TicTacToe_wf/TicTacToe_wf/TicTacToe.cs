namespace TicTacToe_wf
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Hide();
            Players play = new Players();
            play.ShowDialog();
        }

        private void endButton_Click(object sender, EventArgs e) //shuts off app
        {
            Application.Exit();
        }

        private void leaderboardButton_Click(object sender, EventArgs e) //shows leaderboard
        {
            Hide();
            var leader = new Leaderboard_form();
            leader.ShowDialog();
        }

        private void TicTacToe_FormClosed(object sender, FormClosedEventArgs e) //shuts off program when "krizik" is pressed
        {
            Application.Exit();
        }
    }
}