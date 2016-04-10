namespace _02.PermutationsIteratively
{
    using System;
    using System.Linq;

    public class PermutationsIteratively
    {
        private static int countOfPermutations;

        public static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Enumerable.Range(1, n).ToArray();

            PrintPermutations(n, numbers);
            Console.WriteLine($"Total permutations: {countOfPermutations}");
        }

        private static void PrintPermutations(int n, int[] numbers)
        {
            int[] permutation = new int[n];

            int index = 1;
            Console.WriteLine(string.Join(", ", numbers));
            countOfPermutations++;
            while (index < n)
            {
                if (permutation[index] < index)
                {
                    int j = index % 2 == 1 ? permutation[index] : 0;
                    Swap(ref numbers[index], ref numbers[j]);
                    Console.WriteLine(string.Join(", ", numbers));
                    permutation[index]++;
                    index = 1;
                    countOfPermutations++;
                }
                else
                {
                    permutation[index] = 0;
                    index++;
                }
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