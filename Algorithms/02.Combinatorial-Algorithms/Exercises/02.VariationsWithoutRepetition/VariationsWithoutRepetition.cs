namespace _02.VariationsWithoutRepetition
{
    using System;

    public class VariationsWithoutRepetition
    {
        private static int[] array;
        private static bool[] used;

        public static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            array = new int[k];
            used = new bool[n + 1];

            GenerateVariations(n);
        }

        private static void GenerateVariations(int sizeOfSet, int index = 0)
        {
            if (index >= array.Length)
            {
                Print();
                return;
            }

            for (int i = 1; i <= sizeOfSet; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    array[index] = i;
                    GenerateVariations(sizeOfSet, index + 1);
                    used[i] = false;
                }
            }
        }

        private static void Print()
        {
            Console.WriteLine("({0})", string.Join(", ", array));
        }
    }
}