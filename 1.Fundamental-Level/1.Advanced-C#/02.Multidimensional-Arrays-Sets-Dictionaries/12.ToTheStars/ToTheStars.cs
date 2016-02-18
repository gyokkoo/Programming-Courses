namespace _12.ToTheStars
{
    using System;
    using System.Linq;

    public class ToTheStars
    {
        public static void Main()
        {
            const int StartsCount = 3;

            string[] starNames = new string[StartsCount];
            double[] startCoordinatesX = new double[StartsCount];
            double[] startCoordinatesY = new double[StartsCount];

            for (int i = 0; i < StartsCount; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                starNames[i] = inputLine[0];
                startCoordinatesX[i] = double.Parse(inputLine[1]);
                startCoordinatesY[i] = double.Parse(inputLine[2]);
            }

            double[] shipCoordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double shipX = shipCoordinates[0];
            double shipY = shipCoordinates[1];

            int shipMoves = int.Parse(Console.ReadLine());

            for (int i = 0; i < shipMoves + 1; i++)
            {
                bool isInStarSystem = false;

                for (int index = 0; index < StartsCount; index++)
                {
                    double starX = startCoordinatesX[index];
                    double starY = startCoordinatesY[index];
                    if (starX - 1 <= shipX && shipX <= starX + 1 &&
                        starY - 1 <= shipY && shipY <= starY + 1)
                    {
                        Console.WriteLine(starNames[index].ToLower());
                        isInStarSystem = true;
                        break;
                    }
                }

                if (!isInStarSystem)
                {
                    Console.WriteLine("space");
                }

                shipY++;
            }
        }
    }
}