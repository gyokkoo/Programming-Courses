namespace BitCarousel_After
{
    using System;

    public class BitCarousel
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    int rightMostBit = number & 1;
                    number >>= 1;
                    number |= rightMostBit << 5;
                }
                else if (direction == "left")
                {
                    byte leftMostBit = (byte)((number >> 5) & 1);
                    number <<= 1;
                    number &= ~(1 << 6);
                    number |= leftMostBit;
                }
            }

            Console.WriteLine(number);
        }
    }
}