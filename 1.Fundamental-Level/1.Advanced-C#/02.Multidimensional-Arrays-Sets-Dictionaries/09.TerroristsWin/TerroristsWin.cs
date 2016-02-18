namespace _09.TerroristsWin
{
    using System;
    using System.Text.RegularExpressions;

    public class TerroristsWin
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            text = text.Replace("||", "..");

            Regex regex = new Regex(@".*?\|(.*?)\|.*?");
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string bomb = match.Groups[1].ToString();
                int bombPower = GetBombPower(bomb);
                int indexOfBombStart = text.IndexOf(bomb) - bombPower - 1;
                indexOfBombStart = indexOfBombStart < 0 ? 0 : indexOfBombStart;
                int indexOfBombEnd = indexOfBombStart + 2 * bombPower + bomb.Length + 2;
                if (indexOfBombStart == 0)
                {
                    indexOfBombEnd -= bombPower;
                }

                indexOfBombEnd = indexOfBombEnd >= text.Length ? text.Length : indexOfBombEnd;

                string destroyArea = text.Substring(indexOfBombStart, indexOfBombEnd - indexOfBombStart);
                text = text.Replace(destroyArea, new string('.', destroyArea.Length));
            }

            Console.WriteLine(text);
        }

        private static int GetBombPower(string bomb)
        {
            int asciiSum = 0;
            for (int i = 0; i < bomb.Length; i++)
            {
                asciiSum += bomb[i];
            }

            return asciiSum % 10;
        }
    }
}