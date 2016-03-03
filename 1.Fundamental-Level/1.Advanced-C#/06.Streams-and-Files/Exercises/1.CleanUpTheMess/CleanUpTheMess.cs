namespace _1.CleanUpTheMess
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CleanUpTheMess
    {
        public static void Main()
        {
            StringBuilder textBuilder = new StringBuilder();
            StreamReader reader = new StreamReader("../../Mecanismo.cs");
            using (reader)
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    textBuilder.AppendLine(line);
                    line = reader.ReadLine();
                }
            }

            string text = textBuilder.ToString();
            text = Regex.Replace(text, @"\s*\n+\s*", " ");
            text = Regex.Replace(text, @";\s*", string.Format(";{0}", Environment.NewLine));
            text = Regex.Replace(text, @"\s*\(\s*", "(");
            text = Regex.Replace(text, @"\s*\)\s*", ")");
            text = Regex.Replace(text, @"\s*\.\s*", ".");
            text = Regex.Replace(text, @"\s*\{\s*", string.Format("{0}{{{0}", Environment.NewLine));
            text = Regex.Replace(text, @"}\s*", string.Format("}}{0}", Environment.NewLine));

            StreamWriter writer = new StreamWriter("../../Engine.cs");
            using (writer)
            {
                writer.Write(text);
            }

            Console.WriteLine(text);
            Console.WriteLine("The source code was saved to Engine.cs file.");
        }
    }
}