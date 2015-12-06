using System;

namespace _07.EncapsulationAndPolymorphism_2.Ships
{
    public class Warship : Battleship
    {
        public Warship(string name, double lengthInMeters, double volume)
            : base(name, lengthInMeters, volume)
        {
        }

        public override string Attack(Ship targetShip)
        {
            this.DestroyShip(targetShip);

            return "Victory is ours!";
        }
    }
}
