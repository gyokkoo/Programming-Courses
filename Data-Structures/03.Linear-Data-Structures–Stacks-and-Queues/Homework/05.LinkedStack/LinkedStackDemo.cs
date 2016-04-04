namespace _05.LinkedStack
{
    using System;

    public class LinkedStackDemo
    {
        public static void Main(string[] args)
        {
            var numbers = new LinkedStack<int>();

            for (int i = 1; i <= 10; i++)
            {
                numbers.Push(i * i);
                Console.Write("Pushed -> {0} ", i * i);
                Console.WriteLine("Stack count -> " + numbers.Count);
            }

            Console.WriteLine("The numbers are {0} ", string.Join(" ", numbers.ToArray()));

            while (numbers.Count != 0)
            {
                var removedElement = numbers.Pop();
                Console.Write("Popped -> {0} ", removedElement);
                Console.WriteLine("Stack count -> " + numbers.Count);
            }
        }
    }
}
