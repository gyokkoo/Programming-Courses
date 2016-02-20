namespace _02.ReplaceTag
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
//            string htmlText = 
//@"<ul>
// <li>
//  <a href=""http://softuni.bg"">SoftUni</a>
// </li>
//</ul>";

            string htmlText =
@"<ul>
 <li>
  <a href='http://softuni.bg'>SoftUni</a>
 </li>
</ul>";

            string pattern = @"<a.*href=(.*)>(.*)<\/a>";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(htmlText);
            foreach (Match match in matches)
            {
                string hrefAttribute = match.Groups[1].ToString();
                if (hrefAttribute[0] == hrefAttribute[hrefAttribute.Length - 1])
                {
                    hrefAttribute = hrefAttribute.Replace(hrefAttribute[0].ToString(), "");
                    string value = match.Groups[2].ToString();
                    string replacement = $"[URL href={hrefAttribute}]{value}[/URL]";

                    Console.WriteLine(regex.Replace(htmlText, replacement));
                }
            }
        }
    }
}