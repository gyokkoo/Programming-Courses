using _07.EncapsulationAndPolymorphism_2.Interfaces;

namespace _07.EncapsulationAndPolymorphism_2.Ships
{
    public abstract class Battleship : Ship, IAttack
    {
        protected Battleship(string name, double lengthInMeters, double volume)
            : base(name, lengthInMeters, volume)
        {
        }

        public abstract string Attack(Ship target);

        protected void DestroyShip(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
        }
    }
}
