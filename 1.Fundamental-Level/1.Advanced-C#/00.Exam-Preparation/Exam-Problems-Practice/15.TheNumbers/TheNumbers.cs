namespace _15.TheNumbers
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class TheNumbers
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string onlyNumbers = Regex.Replace(text, @"\D+", " ");
            int[] numbers = onlyNumbers.Trim().Split(' ').Select(int.Parse).ToArray();

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                string hexNumber = "0x" + string.Format("{0:X4}-", numbers[i]).ToUpper();
                if (i == numbers.Length - 1)
                {
                    hexNumber = "0x" + string.Format("{0:X4}", numbers[i]).ToUpper();
                }

                result.Append(hexNumber);
            }
        
            Console.WriteLine(result);
        }
    }
}
