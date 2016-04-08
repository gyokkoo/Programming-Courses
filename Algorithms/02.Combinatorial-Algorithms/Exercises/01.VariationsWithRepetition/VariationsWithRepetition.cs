namespace _01.VariationsWithRepetition
{
    using System;

    public class VariationsWithRepetition
    {
        private static int[] array;

        public static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            array = new int[k];

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
                array[index] = i;
                GenerateVariations(sizeOfSet, index + 1);
            }
        }

        private static void Print()
        {
            Console.WriteLine("({0})", string.Join(", ", array));
        }
    }
}