namespace SOLIDLogger.Appenders
{
    using System;
    using System.IO;
    using Interfaces;

    public class FileAppender : Appender
    {
        private StreamWriter writer;

        public FileAppender(string path, IFormatter formatter)
            : base(formatter)
        {
            this.Path = path;
            this.writer = new StreamWriter(this.Path, true);
        }

        public string Path { get; set; }

        public override void Append(string message, ReportLevel level, DateTime date)
        {

            string output = this.Formatter.Format(message, level, date);
            this.writer.WriteLine(output);
        }

        public void Close()
        {
            this.writer.Close();
        }
    }
}
