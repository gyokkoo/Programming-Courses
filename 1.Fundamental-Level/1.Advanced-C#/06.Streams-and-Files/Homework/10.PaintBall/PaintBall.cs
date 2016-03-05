namespace _10.PaintBall
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class PaintBall
    {
        public static void Main()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 1023;
            }

            bool isBlack = true;
            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] lineParams = line.Split();
                int row = int.Parse(lineParams[0]);
                int bitPos = int.Parse(lineParams[1]);
                int radius = int.Parse(lineParams[2]);

                int startRow = row - radius < 0 ? 0 : row - radius;
                int endRow = row + radius >= numbers.Length ? numbers.Length - 1 : row + radius;
                for (int i = startRow; i <= endRow; i++)
                {
                    int startPos = bitPos - radius < 0 ? 0 : bitPos - radius;
                    int endPos = bitPos + radius >= numbers.Length ? numbers.Length - 1 : bitPos + radius;

                    if (isBlack)
                    {
                        for (int pos = startPos; pos <= endPos; pos++)
                        {
                            numbers[i] &= ~(1 << pos);
                        }
                    }
                    else
                    {
                        for (int pos = startPos; pos <= endPos; pos++)
                        {
                            numbers[i] |= 1 << pos;
                        }
                    }
                }

                isBlack = !isBlack;
                line = Console.ReadLine();
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}