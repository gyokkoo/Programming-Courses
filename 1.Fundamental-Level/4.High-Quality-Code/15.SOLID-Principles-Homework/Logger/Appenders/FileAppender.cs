namespace Logger.Appenders
{
    using System;
    using System.IO;

    using Contracts;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout, string file = "file.txt")
            : base(layout)
        {
            this.File = file;
        }

        public string File { get; set; }

        public override void Append(DateTime date, ReportLevel level, string message)
        {
            if (level >= this.ReportLevel)
            {
                using (StreamWriter writer = new StreamWriter(this.File, true))
                {
                    string output = this.Layout.Format(date, level, message);
                    writer.WriteLine(output);
                }
            }
        }
    }
}