using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_wf
{
    internal class Database
    {
        private string previousFile = "previous.txt";
        private string leaderboardFile = "leaderboard.txt";
        private Dictionary<string, int> leaderboard = new Dictionary<string, int>();
        //Writing names of current players for future use
        public void WritePrevious(string player_o, string player_x)
        {
            File.WriteAllText(previousFile, $"{player_o},{player_x}");
        }
        //Loading names from previous game via text file
        public string[] LoadPrevious()
        { 
            string[] names = File.ReadAllText(previousFile).Split(",");
            return names;
        }
        //Filling and updating leaderboard dictionary
        public void AddToLeaderboard(string winner)
        {
            if(File.Exists(leaderboardFile) && File.ReadAllBytes(leaderboardFile) != null)
            {
                LoadFromLeaderboard();
            }//Checks if the file exists and whether it is empty or not, if not, then it loads dict items from it
            int currentWins;
            if (leaderboard.ContainsKey(winner))
            {
                leaderboard.TryGetValue(winner, out currentWins);
                leaderboard[winner] = currentWins + 1;
            }//Checking if the same name is already present in database, if true then it increments its wins
            else
                leaderboard.Add(winner, 1);
            WriteToLeaderboard();//Writing the contents of dict into a leaderboard file
        }
        public void WriteToLeaderboard()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach(KeyValuePair<string, int> kvp in leaderboard)
            {
                stringBuilder.AppendLine($"{kvp.Key},{kvp.Value}");
            }
            string result = stringBuilder.ToString();
            File.WriteAllText(leaderboardFile, result);
        }
        public Dictionary<string,int> LoadFromLeaderboard()
        {
            foreach(var line in File.ReadLines(leaderboardFile))
            {
                string[] val = line.Split(',');
                leaderboard.Add(val[0], int.Parse(val[1]));
            }
            return leaderboard;
        }
        
    }
}
