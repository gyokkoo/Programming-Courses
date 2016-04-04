namespace _07.LinkedQueue
{
    using System;

    public class LinkedQueueDemo
    {
        public static void Main(string[] args)
        {
            var numbers = new LinkedQueue<int>();

            for (int i = 1; i <= 10; i++)
            {
                numbers.Enqueue(i);
                Console.Write("Enqueue -> {0} ", i);
                Console.WriteLine("Count -> {0}", numbers.Count);
            }

            Console.WriteLine(string.Join(", ", numbers.ToArray()));

            for (int i = 1; i <= 10; i++)
            {
                var removedNumber = numbers.Dequeue();
                Console.Write("Dequeue -> {0} ", removedNumber);
                Console.WriteLine("Count -> {0}", numbers.Count);
            }
        }
    }
}
