namespace _01.MatchFullName
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            const string Pettern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            List<string> names = new List<string>
                                     {
                                         "Ivan Ivanov",
                                         "ivan ivanov",
                                         "Ivan ivanov",
                                         "ivan Ivanov",
                                         "IVan Ivanov",
                                         "Ivan IvAnov",
                                         "Ivan  Ivanov"
                                     };

            Regex regex = new Regex(Pettern);
            foreach (var name in names)
            {
                Console.Write("Is \"{0}\" correct name ? -> ", name);
                Console.WriteLine(regex.IsMatch(name));
            }
        }
    }
}