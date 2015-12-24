namespace Blobs.Models
{
    using Enums;
    using Interfaces;

    public class AggressiveBlobplode : Blob
    {
        private const BehaviourType DefaultBehaviourType = BehaviourType.Aggressive;
        private const AttackType DefaultAttackType = AttackType.Blobplode;

        private readonly int initialHealth;
        private readonly int initialDamage;
        private bool isTriggered = false;
        private bool isUsed = false;

        public AggressiveBlobplode(string name, int health, int damage)
            : base(name, health, damage, DefaultBehaviourType, DefaultAttackType)
        {
            this.initialHealth = health;
            this.initialDamage = damage;
        }

        public override void RespondToChanges()
        {
            if (ShouldActivateBehaviour(this.Health, this.initialHealth) && !this.isTriggered && !this.isUsed)
            {
                this.Damage *= 2;
                this.isTriggered = true;
            }
            else
            {
                this.Update();
            }
        }

        public override void Attack(IBlob defender)
        {
            this.Health -= this.Health / 2;

            if (this.Health < 1)
            {
                this.Health = 1;
            }

            this.RespondToChanges();

            defender.Health -= 2 * this.Damage;

            if (defender.Health < 0)
            {
                defender.Health = 0;
            }

            defender.RespondToChanges();
        }

        public override void Update()
        {
            if (this.isTriggered && !this.isUsed)
            {
                this.Damage -= 5;

                if (this.Damage <= this.initialDamage)
                {
                    this.Damage = this.initialDamage;
                    this.isTriggered = false;
                    this.isUsed = true;
                }
            }
        }
    }
}
