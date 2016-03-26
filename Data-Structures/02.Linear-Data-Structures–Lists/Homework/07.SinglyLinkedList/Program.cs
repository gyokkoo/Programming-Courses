namespace _07.SinglyLinkedList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var list = new SinglyLinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                Console.Write("Added " + i);
                Console.WriteLine(" Count -> " + list.Count);
            }

            Console.WriteLine("Items:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int index = 0;
            for (int i = 0; i < 10; i++)
            {
                list.Remove(i - index++);
                Console.Write("Remmoved " + i);
                Console.WriteLine(" Count -> " + list.Count);
            }

            Console.WriteLine("Items:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}