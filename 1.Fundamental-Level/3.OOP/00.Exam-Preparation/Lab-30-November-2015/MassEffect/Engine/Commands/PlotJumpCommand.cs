using System;
using MassEffect.Exceptions;
using MassEffect.Interfaces;

namespace MassEffect.Engine.Commands
{
    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            string destinationName = commandArgs[2];

            var ship = this.GetShipByName(shipName);

            this.ValidateAlive(ship);

            var previuousLocation = ship.Location;
            var destination = this.GameEngine.Galaxy.GetStarSystemByName(destinationName);

            if (previuousLocation == destination)
            {
                throw new ShipException(string.Format(Messages.ShipAlreadyInStarSystem, destinationName));
            }

            this.GameEngine.Galaxy.TravelTo(ship, destination);

            Console.WriteLine(Messages.ShipTraveled, shipName, previuousLocation.Name, destinationName);
        }
    }
}
