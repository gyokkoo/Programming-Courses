namespace _07.GenericArraySort
{
    using System;

    public class GenericArraySort
    {
        public static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            string[] strings = { "zaz", "cba", "baa", "azis" };
            DateTime[] dates = { new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1) };

            GenericBubbleSort(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            GenericBubbleSort(strings);
            Console.WriteLine(string.Join(", ", strings));

            GenericBubbleSort(dates);
            Console.WriteLine(string.Join(", ", dates));
        }

        private static void GenericBubbleSort<T>(T[] genericArray) where T : IComparable
        {
            for (int i = 0; i < genericArray.Length; i++)
            {
                for (int j = 0; j < genericArray.Length - 1; j++)
                {
                    if (genericArray[j].CompareTo(genericArray[j + 1]) > 0)
                    {
                        T exchangeValue = genericArray[j];
                        genericArray[j] = genericArray[j + 1];
                        genericArray[j + 1] = exchangeValue;
                    }
                }
            }
        }
    }
}