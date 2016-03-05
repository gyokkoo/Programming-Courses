namespace _02.LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        private const string TextPath = "../../text.txt";
        private const string DestinationPath = "../../lines-text.txt";

        public static void Main()
        {
            StreamReader reader = new StreamReader(TextPath);
            StreamWriter writer = new StreamWriter(DestinationPath);

            using (reader)
            {
                using (writer)
                {
                    int lineCounter = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine("Line {0}: {1}", lineCounter, line);
                        line = reader.ReadLine();
                        lineCounter++;
                    }
                }
            }

            Console.WriteLine("The lines-text.txt was saved.");
        }
    }
}