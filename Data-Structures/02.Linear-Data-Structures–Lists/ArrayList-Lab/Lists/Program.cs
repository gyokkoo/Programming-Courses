using System;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList<int> list = new ArrayList<int>();
        int count = 10;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Added element " + i);
            list.Add(i);
        }

        Console.WriteLine("List count -> " + list.Count);

        for (int i = 0; i < count; i++)
        {
            int removedElement = list.RemoveAt(0);
            Console.WriteLine("Removed element " + removedElement);
        }

        Console.WriteLine("List count -> " + list.Count);
    }
}
