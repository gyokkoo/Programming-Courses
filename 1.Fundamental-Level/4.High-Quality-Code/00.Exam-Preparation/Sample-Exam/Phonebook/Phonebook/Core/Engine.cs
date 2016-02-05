namespace Phonebook.Core
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    using Phonebook.Contracts;
    using Phonebook.Models;

    public class Engine
    {
        private const string BulgarianCode = "+359";
        private readonly IPhonebookRepository database; // this works!

        public Engine(IPhonebookRepository database)
        {
            this.database = database;
        }

        public void Run()
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End" || line == null)
                {
                    break;
                }

                Regex regex = new Regex(@"(\w+)\((.+)\)");
                Match match = regex.Match(line);
                string command = match.Groups[1].Value;
                string[] lineParams = match.Groups[2].Value.Split(',');

                string result;

                if (command == "AddPhone" && (lineParams.Length >= 2))
                {
                    result = this.ExecuteAddPhoneCommand(lineParams);
                }
                else if (command == "ChangePhone" && (lineParams.Length == 2))
                {
                    result = this.ExecuteChangePhoneCommand(lineParams);
                }
                else if (command == "List" && (lineParams.Length == 2))
                {
                    result = this.ExecuteListCommand(lineParams);
                }
                else
                {
                    throw new ArgumentException("Invalid command.");
                }

                Console.WriteLine(result);
            }
        }

        private string ExecuteListCommand(string[] lineParams)
        {
            int startIndex = int.Parse(lineParams[0]);
            int count = int.Parse(lineParams[1]);

            StringBuilder result = new StringBuilder();

            PhonebookEntry[] phonebooks;
            try
            {
                phonebooks = this.database.ListEntries(startIndex, count);
            }
            catch (ArgumentException ex)
            {
                return ex.Message;
            }

            bool isFirst = true;
            foreach (var entry in phonebooks)
            {
                if (isFirst)
                {
                    result.Append(entry);
                    isFirst = false;
                }
                else
                {
                    result.Append(Environment.NewLine + entry);
                }
            }

            return result.ToString();
        }

        private string ExecuteChangePhoneCommand(string[] lineParams)
        {
            string oldPhoneNumber = this.CanonicalNumber(lineParams[0]);
            string newPhoneNumber = this.CanonicalNumber(lineParams[1]);

            int phoneChangedCount = this.database.ChangePhone(oldPhoneNumber, newPhoneNumber);

            string result = phoneChangedCount + " numbers changed";

            return result;
        }

        private string ExecuteAddPhoneCommand(string[] lineParams)
        {
            string name = lineParams[0];
            var phoneNumbers = lineParams.Skip(1).ToList();

            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                phoneNumbers[i] = this.CanonicalNumber(phoneNumbers[i]);
            }

            bool hasCreatedEntry = this.database.AddPhone(name, phoneNumbers);

            if (hasCreatedEntry)
            {
                return "Phone entry created";
            }

            return "Phone entry merged";
        }

        private string CanonicalNumber(string num)
        {
            // Removed unused loops
            StringBuilder sb = new StringBuilder();
            foreach (char ch in num)
            {
                if (char.IsDigit(ch) || (ch == '+'))
                {
                    sb.Append(ch);
                }
            }

            if (sb.Length >= 2 && sb[0] == '0' && sb[1] == '0')
            {
                sb.Remove(0, 1);
                sb[0] = '+';
            }

            while (sb.Length > 0 && sb[0] == '0')
            {
                sb.Remove(0, 1);
            }

            if (sb.Length > 0 && sb[0] != '+')
            {
                sb.Insert(0, BulgarianCode);
            }

            return sb.ToString();
        }
    }
}
