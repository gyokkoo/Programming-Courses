namespace Blobs.Models
{
    using System;
    using Enums;
    using Interfaces;

    public class InflatedBlobplode : Blob
    {
        private const BehaviourType DefaultBehaviourType = BehaviourType.Inflated;
        private const AttackType DefaultAttackType = AttackType.Blobplode;

        private readonly int initialHealth;
        private bool isTriggered = false;
        private bool isUsed = false;

        public InflatedBlobplode(string name, int health, int damage)
            : base(name, health, damage, DefaultBehaviourType, DefaultAttackType)
        {
            this.initialHealth = health;
        }

        public override void RespondToChanges()
        {
            if (ShouldActivateBehaviour(this.Health, this.initialHealth) && !this.isTriggered && !this.isUsed)
            {
                this.Health += 50;
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
                this.Health -= 10;

                if (this.Health <= 0)
                {
                    this.isTriggered = false;
                    this.isUsed = true;
                    this.Health = 0;
                }
            }
        }
    }
}
