namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;

        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(this.firstName), "First name cannot be null or empty.");
                }

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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(this.lastName), "Last name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        public string AdditionalInfo { get; set; }
      
        public bool IsOlderThan(Student other)
        {
            DateTime firstDate =
                DateTime.Parse(this.AdditionalInfo.Substring(this.AdditionalInfo.Length - 10));
            DateTime secondDate =
                DateTime.Parse(other.AdditionalInfo.Substring(other.AdditionalInfo.Length - 10));

            return firstDate > secondDate;
        }
    }
}
