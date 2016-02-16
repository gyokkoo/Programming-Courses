namespace _09.StuckNumbers
{
    using System;

    public class StuckNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            bool isFound = false;
            foreach (string a in numbers)
            {
                foreach (string b in numbers)
                {
                    foreach (string c in numbers)
                    {
                        foreach (string d in numbers)
                        {
                            if (a != b && a != c && a != d &&
                                b != c && b != d && c != d)
                            {
                                if (a + b == c + d)
                                {
                                    Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                                    isFound = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}