using System;

/*
Write a method which takes an array of any type and sorts it. 
Use bubble sort or selection sort (your own implementation). 
You may re-use your code from a previous homework and modify it. 
Use a generic method (read in Internet about generic methods in C#). 
Make sure that what you're trying to sort can be sorted – your method should work with 
numbers, strings, dates, etc., but not necessarily with custom classes like Student.
 */
class GenericArraySort
{
    static void Main()
    {
        Console.Title = "Problem 7.	* Generic Array Sort";

        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        string[] strings = { "zaz", "cba", "baa", "azis" };
        DateTime[] dates = 
        {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1)
        };

        GenericBubbleSort(numbers);
        Console.WriteLine(string.Join(", ", numbers));

        GenericBubbleSort(strings);
        Console.WriteLine(string.Join(", ", strings));

        GenericBubbleSort(dates);
        Console.WriteLine(string.Join(", ", dates));
    }

    static void GenericBubbleSort<T>(T[] genericArray) where T : IComparable
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