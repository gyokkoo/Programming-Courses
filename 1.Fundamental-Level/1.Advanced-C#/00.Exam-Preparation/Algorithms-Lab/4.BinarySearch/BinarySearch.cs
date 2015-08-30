using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        int[] myArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int item = int.Parse(Console.ReadLine());

        Array.Sort(myArray);

        Console.WriteLine(SearchBinary(myArray, item, 0, myArray.Length));
    }

    static long SearchBinary(int[] myArray, int item, int left, int right)
    {
        if (right < left)
        {
            return -1;
        }

        int mid = (left + right) >> 1;

        if (item > myArray[mid])
        {
            return SearchBinary(myArray, item, mid + 1, right);
        }
        else if (item < myArray[mid])
        {
            return SearchBinary(myArray, item, left, mid - 1);
        }
        else if (item == myArray[mid])
        {
            for (int i = left; i < right; i++)
            {
                if (myArray[i] == item)
                {
                    return i;
                }
            }

            return mid;
        }

        return -1;
    }
}