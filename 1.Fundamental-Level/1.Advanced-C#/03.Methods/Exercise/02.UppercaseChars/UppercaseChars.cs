namespace _02.UppercaseChars
{
    using System;

    public class UppercaseChars
    {
        public static void Main()
        {
            string str = Console.ReadLine();

            Console.WriteLine(UppercaseCharsAtEvenPosition(str));
        }

        private static string UppercaseCharsAtEvenPosition(string str)
        {
            char[] arrayOfChars = str.ToCharArray();

            for (int i = 0; i < arrayOfChars.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arrayOfChars[i] = char.ToUpper(arrayOfChars[i]);
                }
            }

            string uppercasedStr = new string(arrayOfChars);

            return uppercasedStr;
        }
    }
}