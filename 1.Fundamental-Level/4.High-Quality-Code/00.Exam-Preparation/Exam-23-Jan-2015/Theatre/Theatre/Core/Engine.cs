namespace Theatre.Core
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    using Theatre.Contracts;

    public class Engine : IEngine
    {
        private readonly IPerformanceDatabase database;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;

        public Engine(IPerformanceDatabase database, IInputReader reader, IOutputWriter writer)
        {
            this.database = database;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string line = this.reader.ReadLine();
                if (line == null)
                {
                    return;
                }

                if (line != string.Empty)
                {
                    string[] commandArgs = line
                        .Split(
                        new[] { '(', ',', ')' }, 
                        StringSplitOptions.RemoveEmptyEntries);

                    string command = commandArgs[0];

                    string[] parameters = commandArgs.Skip(1).Select(p => p.Trim()).ToArray();
                    string commandResult;
                    try
                    {
                        switch (command)
                        {
                            case "AddTheatre":
                                commandResult = this.ExecuteAddTheatreCommand(parameters);
                                break;
                            case "PrintAllTheatres":
                                commandResult = this.ExecutePrintAllTheatresCommand();
                                break;
                            case "AddPerformance":
                                commandResult = this.ExecuteAddPerformanceCommand(parameters);
                                break;
                            case "PrintAllPerformances":
                                commandResult = this.ExecutePrintAllPerformancesCommand();
                                break;
                            case "PrintPerformances":
                                commandResult = this.ExecutePrintPerformanceCommand(parameters);
                                break;
                            default:
                                commandResult = "Invalid command!";
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        commandResult = "Error: " + ex.Message;
                    }

                    this.writer.WriteLine(commandResult);
                }
            }
        }

        private string ExecutePrintPerformanceCommand(string[] parameters)
        {
            string commandResult;
            string theatre = parameters[0];

            var performances = this.database.ListPerformances(theatre).Select(
                p =>
                    {
                        string data = p.StartDate.ToString("dd.MM.yyyy HH:mm");
                        return string.Format("({0}, {1})", p.Performances, data);
                    }).ToList();
            if (performances.Any())
            {
                commandResult = string.Join(", ", performances);
            }
            else
            {
                commandResult = "No performances";
            }

            return commandResult;
        }

        private string ExecuteAddPerformanceCommand(string[] parameters)
        {
            string theatreName = parameters[0];
            string performanceTitle = parameters[1];
            DateTime startDateTime = DateTime.ParseExact(parameters[2], "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
            TimeSpan duration = TimeSpan.Parse(parameters[3]);
            decimal price = decimal.Parse(parameters[4], NumberStyles.Float);

            this.database.AddPerformance(theatreName, performanceTitle, startDateTime, duration, price);

            return "Performance added";
        }

        private string ExecutePrintAllPerformancesCommand()
        {
            var performances = this.database.ListAllPerformances().ToList();
            if (performances.Any())
            {
                var result = new StringBuilder();
                for (int i = 0; i < performances.Count; i++)
                {
                    if (i > 0)
                    {
                        result.Append(", ");
                    }

                    string date = performances[i].StartDate.ToString("dd.MM.yyyy HH:mm");
                    result.AppendFormat(
                        "({0}, {1}, {2})", 
                        performances[i].Performances, 
                        performances[i].TheatreName, 
                        date);
                }

                return result.ToString();
            }

            return "No performances";
        }

        private string ExecuteAddTheatreCommand(string[] parameters)
        {
            string theatreName = parameters[0];
            this.database.AddTheatre(theatreName);

            return "Theatre added";
        }

        private string ExecutePrintAllTheatresCommand()
        {
            var theatresCount = this.database.ListTheatres().Count();

            if (theatresCount > 0)
            {
                return string.Join(", ", this.database.ListTheatres());
            }

            return "No theatres";
        }
    }
}