namespace _02.TraverseAndSaveDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class TraverseAndSaveDirectory
    {
        private const string StartDirectory = @"D:\Softuni\Data-Structures";
        private static IDictionary<string, Folder> folders;

        public static void Main(string[] args)
        {
            folders = new Dictionary<string, Folder>();

            var queue = new Queue<string>();
            queue.Enqueue(StartDirectory);

            while (queue.Count > 0)
            {
                var currentFolderPath = queue.Dequeue();

                if (!folders.ContainsKey(currentFolderPath))
                {
                    folders[currentFolderPath] = new Folder(currentFolderPath);
                }

                var currentFolder = folders[currentFolderPath];

                var directoryInfo = new DirectoryInfo(currentFolderPath);
                var files = directoryInfo.GetFiles();
                foreach (var f in files)
                {
                    var file = new File(f.Name, f.Length);
                    currentFolder.Files.Add(file);
                }

                var directories = directoryInfo.GetDirectories();
                foreach (var directory in directories)
                {
                    var folder = new Folder(directory.FullName);
                    folders[directory.FullName] = folder;
                    currentFolder.Folders.Add(folder);

                    queue.Enqueue(directory.FullName);
                }
            }

            var startFolder = folders[StartDirectory];

            Console.WriteLine("Total size of {0} directiory is: {1} bytes.", startFolder.Name, startFolder.GetSize());
        }
    }
}
