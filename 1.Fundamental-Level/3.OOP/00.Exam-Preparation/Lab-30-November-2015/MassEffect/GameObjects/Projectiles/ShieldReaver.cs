using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class ShieldReaver : Projectile
    {
        public ShieldReaver(int damage)
            : base(damage)
        {
        }

        public override void Hit(IStarship targetShip)
        {
            targetShip.Health -= this.Damage;
            targetShip.Shields -= this.Damage * 2;
        }
    }
}
