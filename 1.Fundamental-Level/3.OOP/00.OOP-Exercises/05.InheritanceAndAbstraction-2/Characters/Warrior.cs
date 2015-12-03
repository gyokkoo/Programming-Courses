using System;

namespace _05.InheritanceAndAbstraction_2.Characters
{
    public class Warrior : Character
    {
        private const int DefaultWarriorHealth = 300;
        private const int DefaultWarriorMana = 0;
        private const int DefaultWarriorDamage = 100;

        public Warrior()
            : base(DefaultWarriorHealth, DefaultWarriorMana, DefaultWarriorDamage)
        {
        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
        }
    }
}
