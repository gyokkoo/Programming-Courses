namespace BULS.Models
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<User>();
            this.Lectures = new List<Lecture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException(
                        "The course name must be at least 5 symbols long.");
                }

                this.name = value;
            }
        }

        public IList<Lecture> Lectures { get; private set; }

        public IList<User> Students { get; private set; }

        public void AddLecture(Lecture lecture)
        {
            this.Lectures.Add(lecture);
        }

        public void AddStudent(User student)
        {
            this.Students.Add(student);
        }
    }
}
