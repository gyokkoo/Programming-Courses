using System.Text;

namespace FootballLeague.Models
{
    public class Match
    {
        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public Score Score { get; set; }

        public int Id { get; set; }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append($" -> ID:{this.Id}: {this.HomeTeam.Name} vs {this.AwayTeam.Name}");

            output.Append(this.IsDraw()
                ? $" finished draw {this.Score}"
                : $" winner is {this.GetWinner().Name} with score: {this.Score}");

            return output.ToString();
        }
    }
}
