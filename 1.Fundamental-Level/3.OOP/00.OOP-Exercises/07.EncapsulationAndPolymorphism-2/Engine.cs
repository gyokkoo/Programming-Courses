using _07.EncapsulationAndPolymorphism_2.Interfaces;
using _07.EncapsulationAndPolymorphism_2.Ships;
using System;
using System.Collections.Generic;

namespace _07.EncapsulationAndPolymorphism_2
{
    public class Engine
    {
        private static readonly Random Rand = new Random();
        private readonly List<Ship> ships = new List<Ship>();

        public void Run()
        {
            this.PopulateShips();

            for (int i = 0; i < 5; i++)
            {
                string attackResult = this.SimulateAttack();

                Console.WriteLine(attackResult);
            }
        }

        private void PopulateShips()
        {
            ships.AddRange(new Ship[]
            {
                new AircraftCarrier("Omaha", 120, 1500, 50),
                new CargoShip("Jersey", 55, 250),
                new Destroyer("York", 155, 2100, 700),
                new Warship("Vegas", 210, 2400),
                new Yacht("Minie", 15, 200),
            });
        }

        private string SimulateAttack()
        {
            int attackerIndex = Rand.Next(0, this.ships.Count);
            int defenderIndex = Rand.Next(0, this.ships.Count);

            while (defenderIndex == attackerIndex)
            {
                defenderIndex = Rand.Next(0, this.ships.Count);
            }

            Ship attacker = this.ships[attackerIndex];
            Ship defender = this.ships[defenderIndex];

            if (!(attacker is Battleship))
            {
                return "Attacking ship cannot attack other ships.";
            }

            if (attacker.IsDestroyed)
            {
                return "Attacking ship is destroyed.";
            }

            if (defender.IsDestroyed)
            {
                return "Defending ship is already destroyed.";
            }

            IAttack attackingShip = (IAttack)attacker;
            return attackingShip.Attack(defender);
        }
    }
}
