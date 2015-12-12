using System;
using System.Linq;
using System.Text;
using MassEffect.Interfaces;

namespace MassEffect.Engine.Commands
{
    public class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string locationName = commandArgs[1];

            var shipsInSystem = this.GameEngine.Starships
                .Where(s => s.Location.Name == locationName);

            var intactShips = shipsInSystem
                .Where(s => s.Health > 0)
                .OrderByDescending(s => s.Health)
                .ThenByDescending(s => s.Shields);

            StringBuilder output = new StringBuilder();
            output.AppendLine("Intact ships:");
            output.AppendLine(intactShips.Any() ? string.Join("\n", intactShips) : "N/A");

            var destroyedShips = shipsInSystem
                .Where(s => s.Health <= 0)
                .OrderBy(s => s.Name);

            output.AppendLine("Destroyed ships:");
            output.Append(destroyedShips.Any() ? string.Join("", destroyedShips) : "N/A");

            Console.WriteLine(output.ToString());
        }
    }
}
