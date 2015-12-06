using System;

namespace _07.EncapsulationAndPolymorphism_2.Ships
{
    public class Yacht : Ship
    {
        public Yacht(string name, double lengthInMeters, double volume)
            : base(name, lengthInMeters, volume)
        {
        }
    }
}
