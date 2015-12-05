using System;

namespace _1.HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }

            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("The faculty number must be between 5 to 10 digits/letters.");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} with faculty number: {2}",
                    this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
