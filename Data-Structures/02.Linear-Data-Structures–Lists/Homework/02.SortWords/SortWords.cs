namespace _02.SortWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortWords
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var sortedWords = words.OrderBy(word => word);

            Console.WriteLine(string.Join(" ", sortedWords));
        }
    }
}