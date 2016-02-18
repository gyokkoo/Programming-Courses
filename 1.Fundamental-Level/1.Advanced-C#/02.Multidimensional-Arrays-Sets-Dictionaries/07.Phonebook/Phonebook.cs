namespace _07.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, HashSet<string>>();

            FillPhonebook(phonebook);

            while (true)
            {
                string searchName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(searchName))
                {
                    break;
                }

                if (phonebook.ContainsKey(searchName))
                {
                    Console.WriteLine("{0} -> {1}", searchName, string.Join(", ", phonebook[searchName]));
                }
                else
                {
                    Console.WriteLine($"Contact {searchName} does not exist.");
                }
            }
        }

        private static void FillPhonebook(IDictionary<string, HashSet<string>> phonebook)
        {
            string line = Console.ReadLine();
            while (line != "search")
            {
                string[] lineParams = line.Split('-');
                string name = lineParams[0];
                string number = lineParams[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = new HashSet<string>();
                }

                phonebook[name].Add(number);

                line = Console.ReadLine();
            }
        }
    }
}