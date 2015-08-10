using System;
using System.Linq;
using System.Collections.Generic;
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

        Console.WriteLine(SortArray(numbers));
        Console.WriteLine(SortArray(strings));
        Console.WriteLine(SortArray(dates));
    }

    static string SortArray<T>(IEnumerable<T> array)
    {
        List<T> temp = array.ToList();
        List<T> sorted = new List<T>();

        while (temp.Count > 0)
        {
            var x = temp.Min();
            sorted.Add(x);
            temp.Remove(x);
        }

        return String.Join(", ", sorted);
    }
}