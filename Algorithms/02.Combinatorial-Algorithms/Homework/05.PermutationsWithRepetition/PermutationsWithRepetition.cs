namespace _05.PermutationsWithRepetition
{
    using System;

    public class PermutationsWithRepetition
    {
        public static void Main()
        {
            var arr = new[] { 1, 3, 5, 5 };
            //var arr = new[] { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

            GeneratePermutations(arr, 0, arr.Length - 1);
        }

        private static void GeneratePermutations(int[] arr, int start, int end)
        {
            Console.WriteLine("({0})", string.Join(", ", arr));

            for (int left = end - 1; left >= start; left--)
            {
                for (int right = left + 1; right <= end; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        GeneratePermutations(arr, left + 1, end);
                    }
                }

                var firstElement = arr[left];
                for (int i = left; i <= end - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[end] = firstElement;
            }
        }

        private static void Swap(ref int i, ref int j)
        {
            if (i == j)
            {
                return;
            }

            i ^= j;
            j ^= i;
            i ^= j;
        }
    }
}