namespace Debugging_BitCarousel
{
    using System;

    class BitCarousel_broken
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    int rightMostBit = number & 1;
                    number = number >> 1;
                    number = number | (rightMostBit << 5);
                }
                else if (direction == "left")
                {
                    int leftMostBit = (number >> 5) & 1;
                    number = number << 1;
                    number = number & (~(1 << 6));
                    number = number | leftMostBit;
                }
            }

            Console.WriteLine(number);
        }
    }
}
