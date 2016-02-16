namespace _01.SortArrayOfNumbers
{
    using System;
    using System.Linq;

    public class SortArrayOfNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
