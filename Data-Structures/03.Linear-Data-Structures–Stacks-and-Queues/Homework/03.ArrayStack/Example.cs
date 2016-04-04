namespace _03.ArrayStack
{
    using System;

    public class Example
    {
        public static void Main()
        {
            var numbers = new ArrayStack<int>(1);

            for (int i = 0; i < 10; i++)
            {
                numbers.Push(i);
            }

            while (numbers.Count > 0)
            {
                var removedNumber = numbers.Pop();
                Console.WriteLine(removedNumber);
            }
        }
    }
}
