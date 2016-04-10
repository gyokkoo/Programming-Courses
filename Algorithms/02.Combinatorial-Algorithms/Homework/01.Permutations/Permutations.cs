namespace _01.Permutations
{
    using System;
    using System.Linq;

    public class Permutations
    {
        private static int countOfPermutations;

        public static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            var array = Enumerable.Range(1, n).ToArray();

            GeneratePermutations(array);

            Console.WriteLine($"Total permutations: {countOfPermutations}");
        }

        private static void GeneratePermutations(int[] array, int index = 0)
        {
            if (index >= array.Length)
            {
                Print(array);
                countOfPermutations++;
                return;
            }

            for (int i = index; i < array.Length; i++)
            {
                Swap(ref array[index], ref array[i]);
                GeneratePermutations(array, index + 1);
                Swap(ref array[index], ref array[i]);
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

        private static void Print(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
