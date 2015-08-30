using System;
using System.Linq;
class InsertionSort
{
    static void Main()
    {
        long[] myArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        for (int i = 1; i < myArray.Length; i++)
        {
            if (myArray[i - 1] > myArray[i])
            {
                int j = i;
                while (j > 0 && (myArray[j - 1] > myArray[j]))
                {
                    long temp = myArray[j];
                    myArray[j] = myArray[j - 1];
                    myArray[j - 1] = temp;
                    j--;
                }
            }
        }

        Console.WriteLine(string.Join(" ", myArray));
    }
}