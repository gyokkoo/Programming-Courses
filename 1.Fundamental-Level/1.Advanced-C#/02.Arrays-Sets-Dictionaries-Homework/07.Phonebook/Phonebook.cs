using System;
using System.Collections.Generic;
/*
Write a program that receives some info from the console about people and their phone numbers.
You are free to choose the manner in which the data is entered; each entry should have just one name and one number (both of them strings). 
After filling this simple phonebook, upon receiving the command "search", your program should be able to perform 
a search of a contact by name and print her details in format "{name} -> {number}". 
In case the contact isn't found, print "Contact {name} does not exist."
Input:
Nakov-0888080808
search
Mariika
Nakov
Output:
Contact Mariika does not exist.
Nakov -> 0888080808
 */
class Phonebook
{
    static void Main()
    {
        Console.Title = "Problem 7.	Phonebook";

        var phonebook = new Dictionary<string, HashSet<string>>();

        FillPhonebook(phonebook);

        while (true)
        {
            string searchName = Console.ReadLine();

            if (phonebook.ContainsKey(searchName))
            {
                foreach (var phoneNumber in phonebook[searchName])
                {
                    Console.WriteLine("{0} -> {1}", searchName, phoneNumber);
                }
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", searchName);
            }
        }
    }

    static void FillPhonebook(Dictionary<string, HashSet<string>> phonebook)
    {
        string inputLine = Console.ReadLine();
        while (inputLine != "search")
        {
            string[] inputData = inputLine.Split('-');
            string name = inputData[0];
            string phoneNumber = inputData[1];

            if (!phonebook.ContainsKey(name))
            {
                phonebook[name] = new HashSet<string>();
                phonebook[name].Add(phoneNumber);
            }
            else
            {
                phonebook[name].Add(phoneNumber);
            }

            inputLine = Console.ReadLine();
        }
    }
}