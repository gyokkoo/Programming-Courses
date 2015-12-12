using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class PenetrationShell : Projectile
    {
        public PenetrationShell(int damage)
            : base(damage)
        {
        }

        public override void Hit(IStarship targetShip)
        {
            targetShip.Health -= this.Damage;
        }
    }
}
