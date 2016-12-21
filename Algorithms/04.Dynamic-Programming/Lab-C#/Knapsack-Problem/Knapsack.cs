namespace Knapsack_Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Knapsack
    {
        public static void Main()
        {
            var items = new[]
            {
                new Item { Weight = 5, Price = 30 },
                new Item { Weight = 8, Price = 120 },
                new Item { Weight = 7, Price = 10 },
                new Item { Weight = 0, Price = 20 },
                new Item { Weight = 4, Price = 50 },
                new Item { Weight = 5, Price = 80 },
                new Item { Weight = 2, Price = 10 }
            };

            var knapsackCapacity = 20;

            var itemsTaken = FillKnapsack(items, knapsackCapacity);

            Console.WriteLine("Knapsack weight capacity: {0}", knapsackCapacity);
            Console.WriteLine("Take the following items in the knapsack:");
            foreach (var item in itemsTaken)
            {
                Console.WriteLine(
                    "  (weight: {0}, price: {1})",
                    item.Weight,
                    item.Price);
            }

            Console.WriteLine("Total weight: {0}", itemsTaken.Sum(i => i.Weight));
            Console.WriteLine("Total price: {0}", itemsTaken.Sum(i => i.Price));
        }

        public static Item[] FillKnapsack(Item[] items, int capacity)
        {
            var maxPrice = new int[items.Length, capacity + 1];
            var isItemTaken = new bool[items.Length, capacity + 1];

            for (int c = 0; c < capacity + 1; c++)
            {
                if (items[0].Weight <= c)
                {
                    maxPrice[0, c] = items[0].Price;
                    isItemTaken[0, c] = true;
                }
            }

            for (int i = 1; i < maxPrice.GetLength(0); i++)
            {
                for (int c = 0; c < maxPrice.GetLength(1); c++)
                {
                    // Don't take item
                    maxPrice[i, c] = maxPrice[i - 1, c];
                    var remainingCapacity = c - items[i].Weight;

                    // Take item
                    if (remainingCapacity >= 0 && 
                        items[i].Price + maxPrice[i - 1, remainingCapacity] > maxPrice[i - 1, c])
                    {
                        maxPrice[i, c] = items[i].Price + maxPrice[i - 1, remainingCapacity];
                        isItemTaken[i, c] = true;
                    }
                }
            }

            var itemsTaken = new List<Item>();
            var index = items.Length - 1;
            while (index >= 0)
            {
                if (isItemTaken[index, capacity])
                {
                    itemsTaken.Add(items[index]);
                    capacity -= items[index].Weight;
                }

                index--;
            }

            return itemsTaken.ToArray();
        }
    }
}
