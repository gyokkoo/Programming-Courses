using System;
using System.Linq;

public class AnimalsMain
{
    public static void Main()
    {
        Console.Title = "Problem 2.	Animals";

        Animal[] arrayOfAnimals = new Animal[]
        {
            new Dog("Rex", 5, "male", "German Shepherd"),
            new Dog("Max", 2, "female", "Poodle"),
            new Frog("Parkurcho", 1, "male", false),
            new Kitten("Lucy", 5, "female", ConsoleColor.White),
            new Tomcat("Tom", 10, "male", ConsoleColor.Black)
        };

        double averageAge = arrayOfAnimals.Average(a => a.Age);

        Console.WriteLine("The average age of the animals is {0} years.", Math.Ceiling(averageAge));
    }
}

