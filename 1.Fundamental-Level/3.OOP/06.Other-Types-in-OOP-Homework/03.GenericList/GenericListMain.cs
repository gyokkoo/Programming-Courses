using System;

namespace _03.GenericList
{
    public class GenericListMain
    {
        public static void Main()
        {
            Console.Title = "Problem 3.	Generic ";

            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(5);
            numbers.Add(50);
            numbers.Add(500);
            numbers.Add(1000);

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());

            Console.WriteLine(numbers.GetAtIndex(1));
            numbers.Insert(1, 25);
            Console.WriteLine(numbers.IndexOf(50));
            Console.WriteLine(numbers.Contains(5));
            numbers.Remove(5);
            Console.WriteLine(numbers);
            numbers.Clear();
            Console.WriteLine(numbers);

            Console.WriteLine();
            Console.WriteLine("Problem 4.	Generic List Version");
            System.Reflection.MemberInfo info = typeof(GenericList<>);
            foreach (object attribute in info.GetCustomAttributes(false))
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
