using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.HumanStudentAndWorker
{
    class MainProgram
    {
        static void Main()
        {
            Console.Title = "Problem 1.	Human, Student and Worker";

            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", "a23ld30"),
                new Student("Sasho", "Sashev", "a3d03s322"),
                new Student("Qvor", "Qvorov", "a32ld03"),
                new Student("Stamat", "Semov", "3ssa2s"),
                new Student("Vasil", "Kalev", "3sxxxa2"),
                new Student("Kiril", "Lalev", "slo322"),
                new Student("Dobrin", "Dobrev", "914032"),
                new Student("Veselina", "Peneva", "213033"),
                new Student("Silvya", "Dosheva", "313023"),
                new Student("Dimityr", "Marinov", "z1302s"),
            };

            var sortedStudents = students.OrderBy(student => student.FacultyNumber);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Mariyanka", "Hristova", 700.00m, 8m),
                new Worker("Rumen", "Conev", 750.00m, 8m),
                new Worker("Dimitrichka", "Kyneva", 450.00m, 4m),
                new Worker("Cvetelin", "Kacharov", 680.00m, 8m),
                new Worker("Peyo", "Lambev", 1000.00m, 8.5m),
                new Worker("Nadq", "Petkov", 545.00m, 8m),
                new Worker("Lychezar", "Yordanov", 680.00m, 8m),
                new Worker("Dragan", "Ilchev", 2000.00m, 12m),
                new Worker("Iliq", "Ilkov", 840.00m, 9m),
                new Worker("Galina", "Jivkova", 730.00m, 10m)
            };

            Console.WriteLine(new string('-', 45));

            foreach (var worker in workers.OrderByDescending(p => p.MoneyPerHour()))
            {
                Console.WriteLine(worker.ToString());
            }

            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);

            Console.WriteLine(new string('-', 45));

            foreach (var human in mergedList.OrderBy(x => x.FirstName).ThenBy(y => y.LastName))
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
