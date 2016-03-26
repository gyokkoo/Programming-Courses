namespace _06.ReversedList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            ReversedList<int> numbers = new ReversedList<int>(2);
            Console.WriteLine("Adding elements in the list.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Count = " + numbers.Count);
                Console.WriteLine("Capacity = " + numbers.Capacity);
                numbers.Add(i);
            }

            Console.WriteLine("Removing the first indexes.");
            while (numbers.Count > 0)
            {
                foreach (var number in numbers)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine(" -> Count = " + numbers.Count);

                numbers.Remove(0);
            }
        }
    }
}