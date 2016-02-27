namespace _07.VladkoNotebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class VladkoNotebook
    {
        public static void Main()
        {
            var notebook = new Dictionary<string, Player>();

            FillTheNotebook(notebook);

            string output = GetAggregatedResult(notebook);

            Console.Write(output);
        }

        private static string GetAggregatedResult(Dictionary<string, Player> notebook)
        {
            StringBuilder result = new StringBuilder();

            var validPages = notebook.Where(p => p.Value.Name != null && p.Value.Age != 0).OrderBy(p => p.Key);
            if (!validPages.Any())
            {
                result.AppendLine("No data recovered.");
            }
            else
            {
                foreach (var page in validPages)
                {
                    var player = page.Value;
                    player.Opponents.Sort(StringComparer.Ordinal);

                    result.AppendLine($"Color: {page.Key}");
                    result.AppendLine($"-age: {player.Age}");
                    result.AppendLine($"-name: {player.Name}");

                    string opponents = player.Opponents.Count == 0 ? "(empty)" : string.Join(", ", player.Opponents);
                    result.AppendLine($"-opponents: {opponents}");

                    double rank = (player.Wins + 1) / (player.Losses + 1);
                    result.AppendLine($"-rank: {rank:F2}");
                }
            }

            return result.ToString();
        }

        private static void FillTheNotebook(Dictionary<string, Player> notebook)
        {
            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] lineParams = line.Split('|');

                string color = lineParams[0];
                if (!notebook.ContainsKey(color))
                {
                    notebook[color] = new Player();
                    notebook[color].Opponents = new List<string>();
                }

                switch (lineParams[1])
                {
                    case "age":
                        notebook[color].Age = int.Parse(lineParams[2]);
                        break;
                    case "win":
                        notebook[color].Wins++;
                        notebook[color].Opponents.Add(lineParams[2]);
                        break;
                    case "loss":
                        notebook[color].Losses++;
                        notebook[color].Opponents.Add(lineParams[2]);
                        break;
                    case "name":
                        notebook[color].Name = lineParams[2];
                        break;
                    default:
                        throw new ArgumentException("Invalid command.");
                }

                line = Console.ReadLine();
            }
        }
    }

    public class Player
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Opponents { get; set; }

        public double Wins { get; set; }

        public double Losses { get; set; }
    }
}
