using System.Linq;

namespace MassEffect.Engine.Commands
{
    using Interfaces;
    using Exceptions;

    public abstract class Command
    {
        protected Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public abstract void Execute(string[] commandArgs);

        protected IStarship GetShipByName(string shipName)
        {
            return this.GameEngine.Starships.FirstOrDefault(s => s.Name == shipName);
        }

        protected void ValidateAlive(IStarship ship)
        {
            if (ship.Health <= 0)
            {
                throw new ShipException(string.Format(Messages.ShipDestroyed, ship.Name));
            }
        }
    }
}
