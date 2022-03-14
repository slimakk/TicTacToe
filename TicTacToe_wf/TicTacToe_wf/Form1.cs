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
            Play play = new Play();
            play.ShowDialog();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {

        }

        private void TicTacToe_FormClosed(object sender, FormClosedEventArgs e) //shuts off program when "krizik" is pressed
        {
            Application.Exit();
        }
    }
}