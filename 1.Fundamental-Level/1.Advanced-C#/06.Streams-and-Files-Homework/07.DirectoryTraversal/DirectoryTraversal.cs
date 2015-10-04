using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
Traverse a given directory for all files with the given extension. 
Search through the first level of the directory only and write information about each found file in report.txt.
The files should be grouped by their extension. 
Extensions should be ordered by the count of their files (from most to least). 
If two extensions have equal number of files, order them by name.
Files under an extension should be ordered by their size.
report.txt should be saved on the Desktop. Ensure the desktop path is always valid, regardless of the user.
 */
class DirectoryTraversal
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, double>> dic = new Dictionary<string, Dictionary<string, double>>();
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\report.txt";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("The file report.txt is not found in your dekstop!");
        }
        else
        {
            string directory = File.ReadAllText(filePath);
            var files = Directory.GetFiles(directory);

            foreach (var item in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(item);
                string ext = Path.GetExtension(item);
                FileInfo info = new FileInfo(item);
                double size = info.Length / 1024d;
                if (!dic.ContainsKey(ext))
                {
                    dic[ext] = new Dictionary<string, double>();
                    dic[ext].Add(fileName, size);
                }
                else
                {
                    dic[ext].Add(fileName, size);
                }
            }

            foreach (var item in dic.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var d in item.Value.OrderBy(x => x.Value))
                {
                    Console.WriteLine("--{0}{1} - {2:f3}kb", d.Key, item.Key, d.Value);
                }
            }
        }

    }
}
