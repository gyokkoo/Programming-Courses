namespace _02.LeagueManagerReformatted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LeagueManager
    {
        public static void HandleInput(string input)
        {
            string[] args = input.Split();
            switch (args[0])
            {
                case "AddTeam":
                    AddTeam(args[1], args[2], DateTime.Parse(args[3]));
                    break;
                case "AddMatch":
                    AddMatch(int.Parse(args[1]), args[2], args[3], int.Parse(args[4]), int.Parse(args[5]));
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(args[1], args[2], DateTime.Parse(args[3]), decimal.Parse(args[4]), args[5]);
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMatches();
                    break;
                default:
                    throw new ArgumentException("Unknown command");
            }
        }

        private static void ListMatches()
        {
            Console.WriteLine(League.GetMatches());
        }

        private static void ListTeams()
        {
            Console.WriteLine(League.GetTeams());
        }

        private static void AddPlayerToTeam(string firstName, string lastName, DateTime dateOfBirth, decimal salary, string teamName)
        {
            Team team = League.Teams.FirstOrDefault(t => t.Name == teamName);

            Player player = new Player(firstName, lastName, dateOfBirth, salary, team);

            team.AddPlayer(player);

            Console.WriteLine($" -> {firstName} {lastName} was added to {teamName}");
        }

        private static void AddMatch(int id, string homeTeamStr, string awayTeamStr, int homeTeamGoals, int awayTeamGoals)
        {
            Score score = new Score(homeTeamGoals, awayTeamGoals);

            Team homeTeam = League.Teams.FirstOrDefault(t => t.Name == homeTeamStr);

            Team awayTeam = League.Teams.FirstOrDefault(t => t.Name == awayTeamStr);

            Match match = new Match(homeTeam, awayTeam, score, id);

            League.AddMatchToLeague(match);

            Console.WriteLine($" -> Match with id = {id} was added");
        }

        private static void AddTeam(string name, string nickname, DateTime dateFounded)
        {
            Team team = new Team(name, nickname, dateFounded);

            League.AddTeamToLeague(team);

            Console.WriteLine($" -> {team.Name} was added to the league");
        }
    }

    // Everythings below are dummy methods and classes
    public class Score
    {
        public Score(int homeTeamGoals, int awayTeamGoals)
        {
            throw new NotImplementedException();
        }
    }

    public class Player
    {
        public Player(string firstName, string lastName, DateTime dateOfBirth, decimal salary, Team team)
        {
            throw new NotImplementedException();
        }
    }

    public class Team
    {
        public Team(string name, string nickname, DateTime dateFounded)
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }

        public void AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }
    }

    public class Match
    {
        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            throw new NotImplementedException();
        }
    }

    public class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static bool GetMatches()
        {
            throw new NotImplementedException();
        }

        public static bool GetTeams()
        {
            throw new NotImplementedException();
        }

        public static void AddMatchToLeague(Match match)
        {
            throw new NotImplementedException();
        }

        public static void AddTeamToLeague(Team team)
        {
            throw new NotImplementedException();
        }
    }
}