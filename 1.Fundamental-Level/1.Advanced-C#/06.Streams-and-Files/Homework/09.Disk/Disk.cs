namespace _09.Disk
{
    using System;

    public class Disk
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());

            int centerX = n / 2;
            int centerY = n / 2;
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    int deltaX = x - centerX;
                    int deltaY = y - centerY;
                    if ((deltaX * deltaX) + (deltaY * deltaY) <= r * r)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}