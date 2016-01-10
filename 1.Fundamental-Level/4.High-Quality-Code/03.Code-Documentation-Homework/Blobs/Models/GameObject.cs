namespace Blobs.Models
{
    using System;
    using Interfaces;

    public abstract class GameObject : IGameObject
    {
        private string name;
        private int health;
        private int damage;

        protected GameObject(string name, int health, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be null or whitespace.");
                }

                this.name = value;
            }
        }

        public int Health
        {
            get { return this.health; }

            set { this.health = value; }
        }

        public int Damage
        {
            get { return this.damage; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("damage", "Damage cannot be negative.");
                }

                this.damage = value;
            }
        }
    }
}
