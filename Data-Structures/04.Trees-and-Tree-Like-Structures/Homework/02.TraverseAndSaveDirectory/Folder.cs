namespace _02.TraverseAndSaveDirectory
{
    using System.Collections.Generic;

    public class Folder
    {
        private long size;

        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.Folders = new List<Folder>();
        }

        public string Name { get; private set; }

        public IList<File> Files { get; private set; }

        public IList<Folder> Folders { get; private set; }

        public long GetSize()
        {
            if (this.size != 0 || (this.Folders.Count == 0 && this.Files.Count == 0))
            {
                return this.size;
            }

            foreach (var file in this.Files)
            {
                this.size += file.Size;
            }

            foreach (var folder in this.Folders)
            {
                this.size += folder.GetSize();
            }

            return this.size;
        }
    }
}
