using System;

namespace _05.InheritanceAndAbstraction_2.Characters
{
    public class Mage : Character
    {
        private const int DefaultMageHealth = 100;
        private const int DefaultMageMana = 300;
        private const int DefaultMageDamage = 75;

        public Mage()
            : base(DefaultMageHealth, DefaultMageMana, DefaultMageDamage)
        {
        }

        public override void Attack(Character target)
        {
            this.Mana -= DefaultMageMana;
            target.Health -= 2 * this.Damage;
        }
    }
}
