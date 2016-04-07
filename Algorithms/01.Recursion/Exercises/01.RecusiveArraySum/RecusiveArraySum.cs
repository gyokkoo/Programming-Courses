namespace _01.RecusiveArraySum
{
    using System;

    public class RecusiveArraySum
    {
        public static void Main()
        {
            int[] numbers = { 1, 3, 5, 10, 15, 25, 30 };

            int sum = FindSum(numbers);
            Console.WriteLine("{0} = {1}", string.Join(" + ", numbers), sum);
        }

        private static int FindSum(int[] arr, int index = 0)
        {
            if (index == arr.Length)
            {
                return 0;
            }

            return arr[index] + FindSum(arr, index + 1);
        }
    }
}