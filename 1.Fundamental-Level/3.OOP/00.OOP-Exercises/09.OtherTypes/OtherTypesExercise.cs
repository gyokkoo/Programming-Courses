using System;

namespace _09.OtherTypes
{
    public class OtherTypesExercise
    {
        public static void Main()
        {
            var list = new CustomList<int>();

            list.Add(0);
            list.Add(5);
            list.Add(-1);
            list.Add(101);

            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
