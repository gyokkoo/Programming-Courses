namespace _16.Parachute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Parachute
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            List<string> rows = new List<string>();
            while (line != "END")
            {
                rows.Add(line);
                line = Console.ReadLine();
            }

            int x = 0;
            int y = 0;
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Contains("o"))
                {
                    x = i;
                    y = rows[i].IndexOf('o');
                }
            }

            for (int row = x; row < rows.Count; row++)
            {
                x++;
                int leftWindPower = rows[x].Count(s => s == '<');
                int rightWindPower = rows[x].Count(s => s == '>');

                int power = Math.Abs(leftWindPower - rightWindPower);
                if (rightWindPower > leftWindPower)
                {
                    y += power;
                }
                else if (leftWindPower > rightWindPower)
                {
                    y -= power;
                }

                if (rows[x][y] == '\\' || rows[x][y] == '/')
                {
                    Console.WriteLine("Got smacked on the rock like a dog!");
                    Console.WriteLine("{0} {1}", x, y);
                    break;
                }

                if (rows[x][y] == '_')
                {
                    Console.WriteLine("Landed on the ground like a boss!");
                    Console.WriteLine("{0} {1}", x, y);
                    break;
                }

                if (rows[x][y] == '~')
                {
                    Console.WriteLine("Drowned in the water like a cat!");
                    Console.WriteLine("{0} {1}", x, y);
                    break;
                }
            }
        }
    }
}