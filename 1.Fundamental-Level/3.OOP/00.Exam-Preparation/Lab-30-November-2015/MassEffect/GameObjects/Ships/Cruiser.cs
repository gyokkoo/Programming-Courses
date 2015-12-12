using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Cruiser : Starship
    {
        private const int DefaultHealth = 100;
        private const int DefaultShield = 100;
        private const int DefaultDamage = 50;
        private const double DefaultFuel = 300.0;

        public Cruiser(string name, StarSystem location)
            : base(name, DefaultHealth, DefaultShield, DefaultDamage, DefaultFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new PenetrationShell(this.Damage);
        }
    }
}
