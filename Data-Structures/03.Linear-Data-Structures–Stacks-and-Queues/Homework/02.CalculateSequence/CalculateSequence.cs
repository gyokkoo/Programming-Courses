namespace _02.CalculateSequence
{
    using System;
    using System.Collections.Generic;

    public class CalculateSequence
    {
        private const int Count = 50;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new Queue<int>();

            numbers.Enqueue(n);
            for (int i = 0; i < Count; i++)
            {
                int currentNumber = numbers.Dequeue();

                numbers.Enqueue(currentNumber + 1);
                numbers.Enqueue((2 * currentNumber) + 1);
                numbers.Enqueue(currentNumber + 2);

                Console.Write(currentNumber + " ");
            }

            Console.WriteLine();
        }
    }
}