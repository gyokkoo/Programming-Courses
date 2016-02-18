namespace _01.ReverseString
{
    using System;
    using System.Text;

    public class ReverseString
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            string reversedString = StringReverse(inputString);

            Console.WriteLine(reversedString);
        }

        private static string StringReverse(string inputString)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                sb.Append(inputString[i]);
            }

            string reversedString = sb.ToString();

            return reversedString;
        }
    }
}