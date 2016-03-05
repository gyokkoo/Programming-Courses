namespace _01.OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        private const string Path = "../../text.txt";

        public static void Main()
        {
            StreamReader reader = new StreamReader(Path);
            using (reader)
            {
                int lineCounter = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineCounter % 2 == 1)
                    {
                        Console.WriteLine("Line {0}: {1}", lineCounter, line);
                    }

                    line = reader.ReadLine();
                    lineCounter++;
                }
            }
        }
    }
}