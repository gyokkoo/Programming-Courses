using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Dreadnought : Starship
    {
        private const int DefaultHealth = 200;
        private const int DefaultShield = 300;
        private const int DefaultDamage = 150;
        private const double DefaultFuel = 700.0;

        public Dreadnought(string name, StarSystem location)
            : base(name, DefaultHealth, DefaultShield, DefaultDamage, DefaultFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new Laser(this.Shields / 2 + this.Damage);
        }

        public override void RespondToAttack(IProjectile attack)
        {
            this.Shields += 50;

            attack.Hit(this);

            this.Shields -= 50;
        }
    }
}
