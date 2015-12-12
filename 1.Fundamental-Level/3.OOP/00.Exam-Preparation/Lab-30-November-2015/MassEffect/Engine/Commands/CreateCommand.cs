using System;
using System.Linq;
using MassEffect.Engine.Factories;
using MassEffect.Exceptions;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Ships;

namespace MassEffect.Engine.Commands
{
    using Interfaces;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string type = commandArgs[1];
            string shipName = commandArgs[2];
            string locationName = commandArgs[3];

            bool shipAlreadyExists = this.GameEngine.Starships.
                Any(s => s.Name == shipName);

            if (shipAlreadyExists)
            {
                throw new ShipException(Messages.DuplicateShipName);
            }

            StarshipType shipType = (StarshipType)Enum.Parse(typeof(StarshipType), type);

            var location = this.GameEngine.Galaxy.GetStarSystemByName(locationName);

            var ship = ShipFactory.CreateShip(shipType, shipName, location);

            this.GameEngine.Starships.Add(ship);

            for (int i = 4; i < commandArgs.Length; i++)
            {
                var enhancementType = (EnhancementType)Enum.Parse(typeof(EnhancementType), commandArgs[i]);

                var enhancement = EnhancementFactory.Create(enhancementType);

                ship.AddEnhancement(enhancement);
            }

            Console.WriteLine(Messages.CreatedShip, type, shipName);
        }
    }
}
