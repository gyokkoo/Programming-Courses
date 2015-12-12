using System.Text;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Frigate : Starship
    {
        private const int DefaultHealth = 60;
        private const int DefaultShield = 50;
        private const int DefaultDamage = 30;
        private const double DefaultFuel = 220.0;
        private int projectilesFired;

        public Frigate(string name, StarSystem location)
            : base(name, DefaultHealth, DefaultShield, DefaultDamage, DefaultFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            this.projectilesFired++;
            return new ShieldReaver(this.Damage);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());

            if (this.Health > 0)
            {
                output.Append($"-Projectiles fired: {this.projectilesFired}");
            }

            return output.ToString();
        }
    }
}
