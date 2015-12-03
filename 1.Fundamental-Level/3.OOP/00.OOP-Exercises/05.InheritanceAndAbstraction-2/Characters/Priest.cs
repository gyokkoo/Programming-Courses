using _05.InheritanceAndAbstraction_2.Interfaces;
using System;

namespace _05.InheritanceAndAbstraction_2.Characters
{
    public class Priest : Character, IHeal
    {
        private const int DefaultPriestHealth = 125;
        private const int DefaultPriestMana = 200;
        private const int DefaultPriestDamage = 100;

        public Priest()
            : base(DefaultPriestHealth, DefaultPriestMana, DefaultPriestMana)
        {
        }

        public override void Attack(Character target)
        {
            this.Mana -= DefaultPriestDamage;
            target.Health -= this.Damage;
            this.Health += this.Damage / 10;
        }

        public void Heal(Character target)
        {
            this.Mana -= DefaultPriestDamage;
            target.Health += 150;
        }
    }
}