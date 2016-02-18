namespace _02.StringLength
{
    using System;

    public class StringLength
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            string resultString = string.Empty;

            if (inputString.Length < 20)
            {
                resultString = inputString + new string('*', 20 - inputString.Length);
            }
            else if (inputString.Length > 20)
            {
                resultString = inputString.Substring(0, 20);
            }

            Console.WriteLine(resultString);
        }
    }
}