namespace _03.LargerThanNeighbours
{
    using System;

    public class LargerThanNeighbours
    {
        public static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        private static bool IsLargerThanNeighbours(int[] numbers, int i)
        {
            if (numbers.Length == 1)
            {
                return false;
            }

            if (i == 0)
            {
                return numbers[i] > numbers[i + 1];
            }

            if (i == numbers.Length - 1)
            {
                return numbers[i] > numbers[i - 1];
            }

            return numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1];
        }
    }
}