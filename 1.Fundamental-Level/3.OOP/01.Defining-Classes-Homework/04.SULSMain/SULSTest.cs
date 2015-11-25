using System;
using System.Collections.Generic;
using System.Linq;

//решението не е мое
//https://github.com/iordan93/SoftUni-Homeworks/tree/master/Object-Oriented%20Programming/Defining%20Classes/4.%20SoftwareUniversityLearningSystem
class SULSTest

{
    static void Main()
    {
        List<Person> people = new List<Person>()
        {
            new Person("Ivan", "Petrov", 20),
            new Trainer("Koko", "Kolev", 28),
            new JuniorTrainer("Jeko", "Jekov", 20),
            new SeniorTrainer("Svetlin", "Nakov", 35),
            new Student("Student", "One", 25, 12322, 5.12),
            new GraduateStudent("Student", "Two", 26, 12323, 4.96),
            new CurrentStudent("Ivan", "Ivanov", 28, 12324, 6.00),
            new CurrentStudent("Pesho", "Peshev", 29, 14324, 5.00),
            new CurrentStudent("Gosho", "Goshev", 27, 12367, 4.30),
            new CurrentStudent("Nikolay", "Nikolaev", 26, 12328, 4.80),
            new CurrentStudent("Sasho", "Sashev", 24, 12329, 5.80),
            new OnlineStudent("Dragan", "Draganov", 28, 12332, 5.12),
            new OnlineStudent("Kaloyan", "Kaloyanov", 18, 12111, 5.51),
            new DropoutStudent("Mitko", "Ivanov", 28, 11111, 3.12, "The courses are too hard.")
        };

        Console.WriteLine(string.Join(Environment.NewLine, people
            .Where(p => p is CurrentStudent)
            .Cast<CurrentStudent>()
            .OrderBy(s => s.AverageGrade)));
    }
}

