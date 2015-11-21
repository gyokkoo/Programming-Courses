using System;

public class PersonsMain
{
    static void Main()
    {
        Person firstPerson = new Person("Gosho", 25, "gosho.peshev@gmail.com");
        Person secondPerson = new Person("Pesho", 23);
        Person thirdPerson = new Person("Ivan", 15, "ivan.ivanov@abv.bg");
        Person fourthPerson = new Person("Koko", 18);

        Person[] persons = new Person[4];
        persons[0] = firstPerson;
        persons[1] = secondPerson;
        persons[2] = thirdPerson;
        persons[3] = fourthPerson;

        for (int i = 0; i < persons.Length; i++)
        {
            Console.WriteLine("----- [Person {0}] -----", i + 1);
            Console.WriteLine(persons[i].ToString());
            Console.WriteLine();
        }

        //Person wrongAge = new Person("Nikolay", -15);
        //Console.WriteLine(wrongAge.ToString());

        //Person wrongEmail = new Person("Wankata", 35, "wankata.email.com");
        //Console.WriteLine(wrongEmail.ToString());
    }
}
