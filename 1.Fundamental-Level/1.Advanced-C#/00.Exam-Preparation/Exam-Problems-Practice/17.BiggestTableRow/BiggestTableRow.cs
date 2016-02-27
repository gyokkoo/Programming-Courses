namespace _17.BiggestTableRow
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class BiggestTableRow
    {
        public static void Main()
        {
            var maxStores = new List<string>();
            double maxSum = double.MinValue;

            string tableTag = Console.ReadLine();
            string townLine = Console.ReadLine();
            string line = Console.ReadLine();
            while (line != "</table>")
            {
                Regex regex = new Regex(@"<tr><td>(.+?)<\/td><td>(.+?)<\/td><td>(.+?)<\/td><td>(.+?)<\/td><\/tr>");
                Match match = regex.Match(line);

                List<string> townStores = new List<string>();
                double sum = 0;
                for (int i = 2; i <= 4; i++)
                {
                    string storeValue = match.Groups[i].Value;
                    if (storeValue != "-")
                    {
                        townStores.Add(storeValue);
                        sum += double.Parse(storeValue);
                    }
                }

                if (maxSum < sum)
                {
                    maxSum = sum;
                    maxStores = townStores;
                }
               
                line = Console.ReadLine();
            }

            if (maxStores.Any())
            {
                Console.WriteLine("{0} = {1}", maxSum, string.Join(" + ", maxStores));
            }
            else
            {
                Console.WriteLine("no data");
            }
        }
    }
}
