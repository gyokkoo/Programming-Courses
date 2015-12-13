using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballLeague.Models;

namespace FootballLeague
{
    public static class League
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

        public static void AddTeamToLeague(Team teamToAdd)
        {
            if (teams.Any(t => t.Name == teamToAdd.Name))
            {
                throw new ArgumentException($" -> {teamToAdd.Name} already exists in the league");
            }

            teams.Add(teamToAdd);
        }

        public static void AddMatchToLeague(Match matchToAdd)
        {
            if (matches.Any(m => m.Id == matchToAdd.Id))
            {
                throw new ArgumentException(" -> The match already exists");
            }

            matches.Add(matchToAdd);
        }

        public static string GetTeams()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(" ----------TEAMS-IN-THE-LEAGUE---------");
            foreach (var team in Teams)
            {
                output.Append(team);
            }

            return output.ToString();
        }

        public static string GetMatches()
        {
            StringBuilder output = new StringBuilder();

            if (matches.Any())
            {
                output.AppendLine("----------MATCHES-IN-THE-LEAGUE---------");
                foreach (var match in matches)
                {
                    output.AppendLine(match.ToString());
                }
            }
            else
            {
                output.Append(" -> The League has not played matches yet");
            }

            return output.ToString();
        }
    }
}
