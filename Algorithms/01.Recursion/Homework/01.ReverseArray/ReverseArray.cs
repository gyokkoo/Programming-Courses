namespace _01.ReverseArray
{
    using System;

    public class ReverseArray
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] reversedArray = new string[array.Length];

            ReverseArr(array, reversedArray);

            Console.WriteLine(string.Join(" ", reversedArray));
        }

        private static void ReverseArr(string[] arr, string[] reversedArr, int index = 0)
        {
            if (index == arr.Length)
            {
                return;
            }

            reversedArr[index] = arr[arr.Length - index - 1];

            ReverseArr(arr, reversedArr, index + 1);
        }
    }
}