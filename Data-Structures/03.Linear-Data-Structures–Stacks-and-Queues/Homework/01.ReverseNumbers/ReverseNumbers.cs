namespace _01.ReverseNumbers
{
    using System;
    using System.Collections.Generic;

    public class ReverseNumbers
    {
        public static void Main()
        {
            var numbers = new Stack<int>();

            string[] lineArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in lineArgs)
            {
                int number;
                if (int.TryParse(item, out number))
                {
                    numbers.Push(number);
                }
            }

            Console.WriteLine(string.Join(" ", numbers.ToArray()));
        }
    }
}