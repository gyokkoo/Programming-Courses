namespace Blobs.Models
{
    using Enums;
    using Interfaces;

    public abstract class Blob : GameObject, IBlob
    {
        protected Blob(string name, int health, int damage, BehaviourType behaviourType, AttackType attackType)
            : base(name, health, damage)
        {
            this.BehaviourType = behaviourType;
            this.AttackType = attackType;
        }

        public BehaviourType BehaviourType { get; private set; }

        public AttackType AttackType { get; private set; }

        public abstract void RespondToChanges();

        public abstract void Attack(IBlob blob);

        public abstract void Update();

        protected static bool ShouldActivateBehaviour(int currentHealth, int initialHealth)
        {
            return currentHealth <= initialHealth/2;
        }

        public override string ToString()
        {
            string output;

            if (this.Health > 0)
            {
                output = string.Format("Blob {0}: {1} HP, {2} Damage", this.Name, this.Health, this.Damage);
            }
            else
            {
                output = string.Format("Blob {0} KILLED", this.Name);
            }
            return output;
        }
    }
}
