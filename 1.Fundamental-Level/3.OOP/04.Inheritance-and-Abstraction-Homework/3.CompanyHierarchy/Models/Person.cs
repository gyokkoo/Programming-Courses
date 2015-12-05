using _3.CompanyHierarchy.Interfaces;
using System;

namespace _3.CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private uint id;
        private string firstName;
        private string lastName;

        public Person(uint id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public uint Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.ValidateName(value);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.ValidateName(value);

                this.lastName = value;
            }
        }

        private void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null, empty or whitespace.");
            }
        }
    }
}
