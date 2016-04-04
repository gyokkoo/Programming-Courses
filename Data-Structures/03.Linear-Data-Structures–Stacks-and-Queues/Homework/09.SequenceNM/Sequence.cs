namespace _09.SequenceNM
{
    using System;
    using System.Collections.Generic;

    public class Sequence
    {
        public static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(inputLine[0]);
            int m = int.Parse(inputLine[1]);

            var queue = new Queue<Item>();
            var result = new Stack<int>();

            queue.Enqueue(new Item(n, null));

            while (queue.Count != 0)
            {
                var item = queue.Dequeue();

                if (item.Value < m)
                {
                    queue.Enqueue(new Item(item.Value * 2, item));
                    queue.Enqueue(new Item(item.Value + 2, item));
                    queue.Enqueue(new Item(item.Value + 1, item));
                }

                if (item.Value == m)
                {
                    while (item != null)
                    {
                        result.Push(item.Value);
                        item = item.PreviousItem;
                    }

                    break;
                }
            }

            if (result.Count != 0)
            {
                Console.WriteLine(string.Join(" -> ", result));
            }
            else
            {
                Console.WriteLine("No solution");
            }
        }

        private class Item
        {
            public Item(int value, Item previousItem)
            {
                this.Value = value;
                this.PreviousItem = previousItem;
            }

            public int Value { get; }

            public Item PreviousItem { get; }
        }
    }
}