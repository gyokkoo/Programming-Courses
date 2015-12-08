using System;

namespace _01.GalacticGPS
{
    public class GalacticGpsMain
    {
        public static void Main()
        {
            Console.Title = "Problem 1.	Galactic GPS";

            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Location marsLocation = new Location(40.0530202, 21.345322, Planet.Mars);

            Console.WriteLine(home);
            Console.WriteLine(marsLocation);
        }
    }
}
