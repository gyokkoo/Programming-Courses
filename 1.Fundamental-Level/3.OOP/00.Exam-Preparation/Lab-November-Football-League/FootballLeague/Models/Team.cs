using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballLeague.Models
{
    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateFounded;
        private List<Player> players;
        private const int MinimumAllowedYear = 1850;

        public Team(string name, string nickname, DateTime dateFounded)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateFounded = dateFounded;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException(" -> The name should be at least 5 characters long");
                }

                this.name = value;
            }
        }

        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException(" -> The nickname should be at least 5 characters long");
                }

                this.nickname = value;
            }
        }

        public DateTime DateFounded
        {
            get { return this.dateFounded; }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException(
                        $" -> The team founded year must be after {MinimumAllowedYear}");
                }

                this.dateFounded = value;
            }
        }

        public IEnumerable<Player> player
        {
            get { return this.player; }
        }

        private bool IsValidName(string value)
        {
            return string.IsNullOrWhiteSpace(value) || value.Length >= 5;
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException(
                    $"{player.FirstName} {player.LastName} already exists in {player.Team}");
            }

            players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName &&
                                         p.LastName == player.LastName);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($" * {this.Name} ({this.Nickname}) founded in {this.DateFounded:yyyy MMMM dd}");

            output.Append(this.players.Any()
                ? $" ---> with players: {string.Join(", ", this.players.Select(p => p.FirstName + p.LastName).ToList())}"
                : " ---> has no added players");

            return output.ToString();
        }
    }
}
