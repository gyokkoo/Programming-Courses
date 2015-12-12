using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class Laser : Projectile
    {
        public Laser(int damage)
            : base(damage)
        {
        }

        public override void Hit(IStarship targetShip)
        {
            int remainderDamage = this.Damage - targetShip.Shields;
            targetShip.Shields -= this.Damage;

            if (remainderDamage > 0)
            {
                targetShip.Health -= remainderDamage;
            }

        }
    }
}
