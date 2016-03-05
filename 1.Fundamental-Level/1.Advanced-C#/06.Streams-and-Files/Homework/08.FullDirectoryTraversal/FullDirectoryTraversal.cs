namespace _08.FullDirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FullDirectoryTraversal
    {
        public static void Main()
        {
            string[] filePaths = Directory.GetFiles("../../", "*.*", SearchOption.AllDirectories);
            List<FileInfo> files = filePaths.Select(path => new FileInfo(path)).ToList();

            var sorted =
                files.OrderBy(file => file.Length)
                    .GroupBy(file => file.Extension)
                    .OrderByDescending(group => group.Count())
                    .ThenBy(group => group.Key);

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var writer = new StreamWriter(desktop + "/report.txt");
            foreach (var group in sorted)
            {
                writer.WriteLine(group.Key);

                foreach (var x in group)
                {
                    writer.WriteLine("--{0} - {1:F3} kb", x.Name, x.Length / 1024.0);
                }
            }

            writer.Close();
            Console.WriteLine("The report was saved on your desktop.");
        }
    }
}
