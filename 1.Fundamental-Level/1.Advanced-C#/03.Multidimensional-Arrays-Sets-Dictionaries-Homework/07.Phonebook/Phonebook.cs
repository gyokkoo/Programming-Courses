using System;
using System.Collections.Generic;
using System.Linq;
/*
Write a program that receives some info from the console about people and their phone numbers.
You are free to choose the manner in which the data is entered; each entry should have just one name and one number (both of them strings). 
After filling this simple phonebook, upon receiving the command "search", your program should be able to perform 
a search of a contact by name and print her details in format "{name} -> {number}". 
In case the contact isn't found, print "Contact {name} does not exist."
 */
class Phonebook
{
    static void Main()
    {
        Console.Title = "Problem 7.	Phonebook";

        var phonebook = new Dictionary<string, HashSet<string>>();

        string command = "";
        while (command != "search")
        {
            string[] input = Console.ReadLine().Split('-');

            if (input[0] == "search")
            {
                command = "search";
            }
            else
            {
                if (!phonebook.ContainsKey(input[0]))
                {
                    phonebook[input[0]] = new HashSet<string>();
                    phonebook[input[0]].Add(input[1]);
                }
                else
                {
                    phonebook[input[0]].Add(input[1]);
                }
            }
        }

        while (true)
        {
            command = Console.ReadLine();

            if (phonebook.ContainsKey(command))
            {
                foreach (var value in phonebook[command])
                {
                    Console.WriteLine("{0} -> {1}", command, value);
                }
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist", command);
            }
        }

    }
}