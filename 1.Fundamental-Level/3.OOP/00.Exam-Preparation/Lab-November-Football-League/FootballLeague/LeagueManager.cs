using System;
using System.Linq;
using FootballLeague.Models;

namespace FootballLeague
{
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
}
