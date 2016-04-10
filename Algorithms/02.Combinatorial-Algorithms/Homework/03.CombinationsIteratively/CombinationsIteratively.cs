namespace _03.CombinationsIteratively
{
    using System;

    public class CombinationsIteratively
    {
        public static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            GenerateCombinations(n, k);
        }

        private static void GenerateCombinations(int n, int k)
        {
            int[] array = new int[n];
            for (int i = 0; i < k; i++)
            {
                array[i] = i;
            }

            while (array[k - 1] < n)
            {
                for (int i = 0; i < k; i++)
                {
                    Console.Write(array[i] + 1 + " ");
                }

                Console.WriteLine();

                int t = k - 1;
                while (t != 0 && array[t] == n - k + t)
                {
                    t--;
                }

                array[t]++;
                for (int i = t + 1; i < k; i++)
                {
                    array[i] = array[i - 1] + 1;
                }
            }
        }
    }
}
