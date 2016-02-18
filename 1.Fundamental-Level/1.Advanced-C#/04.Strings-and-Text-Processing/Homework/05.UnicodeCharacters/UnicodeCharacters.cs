namespace _05.UnicodeCharacters
{
    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            foreach (char ch in inputString)
            {
                Console.Write("\\u{0:x4}", (int)ch);
            }

            Console.WriteLine();
        }
    }
}