using System;
using MassEffect.Exceptions;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string attackerName = commandArgs[1];
            string targetName = commandArgs[2];

            var attackingShip = GetShipByName(attackerName);
            var targetShip = GetShipByName(targetName);

            this.ProcessStarshipBattle(attackingShip, targetShip);
        }

        private void ProcessStarshipBattle(IStarship attackingShip, IStarship targetShip)
        {

            base.ValidateAlive(attackingShip);
            base.ValidateAlive(targetShip);

            if (attackingShip.Location != targetShip.Location)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }

            var attack = attackingShip.ProduceAttack();
            targetShip.RespondToAttack(attack);

            Console.WriteLine(Messages.ShipAttacked, attackingShip.Name, targetShip.Name);

            if (targetShip.Shields < 0)
            {
                targetShip.Shields = 0;
            }

            if (targetShip.Health <= 0)
            {
                targetShip.Health = 0;
                Console.WriteLine(Messages.ShipDestroyed, targetShip.Name);
            }
        }
    }
}
