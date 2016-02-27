namespace _18.PinValidation
{
    using System;

    public class PinValidation
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            string pin = Console.ReadLine();

            if (IsValidPin(pin, gender) && IsValidName(name))
            {
                Console.WriteLine(@"{{""name"":""{0}"",""gender"":""{1}"",""pin"":""{2}""}}", name, gender, pin);
            }
            else
            {
                Console.WriteLine("<h2>Incorrect data</h2>");
            }
        }

        private static bool IsValidName(string name)
        {
            string[] names = name.Split();
            if (names.Length != 2)
            {
                return false;
            }

            if (char.IsLower(names[0][0]) || char.IsLower(names[1][0]))
            {
                return false;
            }

            return true;
        }

        private static bool IsValidPin(string pin, string gender)
        {
            if (pin.Length != 10)
            {
                return false;
            }

            int year = int.Parse(pin.Substring(0, 2));
            int month = int.Parse(pin.Substring(2, 2));
            int day = int.Parse(pin.Substring(4, 2));

            if (20 <= month && month <= 32)
            {
                year += 1800;
                month -= 20;
            }
            else if (1 <= month && month <= 12)
            {
                year += 1900;
            }
            else if (40 <= month && month <= 52)
            {
                month -= 40;
            }
            else
            {
                return false;
            }

            if (day < 1 || day > DateTime.DaysInMonth(year, month))
            {
                return false;
            }

            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int weight = 0;
            for (int i = 0; i < 9; i++)
            {
                weight += int.Parse(pin[i].ToString()) * weights[i];
            }

            int checkSum = weight % 11;
            checkSum = checkSum == 10 ? 0 : checkSum;
            if (checkSum != int.Parse(pin[9].ToString()))
            {
                return false;
            }

            if (pin[8] % 2 == 0 && gender == "female")
            {
                return false;
            }

            if (pin[8] % 2 == 1 && gender == "male")
            {
                return false;
            }

            return true;
        }
    }
}