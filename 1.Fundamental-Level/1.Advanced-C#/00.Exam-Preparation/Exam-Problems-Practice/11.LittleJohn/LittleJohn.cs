namespace _11.LittleJohn
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class LittleJohn
    {
        public static void Main()
        {
            StringBuilder arrowsBuilder = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                arrowsBuilder.AppendFormat(" {0}", Console.ReadLine());
            }

            const string ArrowPattern = @"(>>>----->>)|(>>----->)|(>----->)";
            Regex arrowMatcher = new Regex(ArrowPattern);
            var arrows = arrowMatcher.Matches(arrowsBuilder.ToString());

            int largeArrowCount = 0;
            int mediumArrowCount = 0;
            int smallArrowCount = 0;

            foreach (Match arrow in arrows)
            {
                if (!string.IsNullOrEmpty(arrow.Groups[1].Value))
                {
                    largeArrowCount++;
                }
                else if (!string.IsNullOrEmpty(arrow.Groups[2].Value))
                {
                    mediumArrowCount++;
                }
                else if (!string.IsNullOrEmpty(arrow.Groups[3].Value))
                {
                    smallArrowCount++;
                }
            }

            string numberAsString = string.Format("{0}{1}{2}", smallArrowCount, mediumArrowCount, largeArrowCount);

            long number = long.Parse(numberAsString);

            string binaryNum = Convert.ToString(number, 2);

            string reversedBinaryNum = new string(binaryNum.Reverse().ToArray());

            string resultAsString = binaryNum + reversedBinaryNum;

            long result = Convert.ToInt64(resultAsString, 2);

            Console.WriteLine(result);
        }
    }
}
