using System;
using System.Collections.Generic;

public class PersonsMain
{
    static void Main()
    {
        Console.Title = "Problem 1.	Persons";

        List<Person> people = new List<Person>()
        {
            new Person("Gosho", 25, "gosho.peshev@gmail.com"),
            new Person("Pesho", 23),
            new Person("Ivan", 15, "ivan.ivanov@abv.bg"),
            new Person("Koko", 18)
        };


        for (int i = 0; i < people.Count; i++)
        {
            Console.WriteLine("----- [Person {0}] -----", i + 1);
            Console.WriteLine(people[i].ToString() + "\n");
        }

        //Person wrongAge = new Person("Nikolay", -15);
        //Console.WriteLine(wrongAge.ToString());

        //Person wrongEmail = new Person("Wankata", 35, "wankata.email.com");
        //Console.WriteLine(wrongEmail.ToString());
    }
}
