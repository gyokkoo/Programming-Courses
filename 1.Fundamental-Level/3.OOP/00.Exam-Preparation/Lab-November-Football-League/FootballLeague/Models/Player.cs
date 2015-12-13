using System;

namespace FootballLeague.Models
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private decimal salary;
        private Team team;

        private const int MinimumAllowedYear = 1980;

        public Player(string firstName, string lastName, DateTime dateOfBirth, decimal salary, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Salary = salary;
            this.Team = team;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException(" -> First name should be at least 3 chars long");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException(" -> Last name should be at least 3 chars long");
                }

                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(" -> Salary cannot be negative");
                }

                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException(" -> Date of birth cannot be earlier than " + MinimumAllowedYear);
                }

                this.dateOfBirth = value;
            }
        }

        public Team Team { get; set; }

        private static bool IsValidName(string value)
        {
            return string.IsNullOrWhiteSpace(value) || value.Length >= 3;
        }

    }
}
