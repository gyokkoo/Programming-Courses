namespace SOLIDLogger.Formatters
{
    using System;
    using System.Text;
    using Interfaces;

    public class XmlFormatter : IFormatter
    {
        public string Format(string msg, ReportLevel level, DateTime date)
        {
            var output = new StringBuilder();

            output.AppendLine("<log>");
            output.AppendLine("<message>" + msg + "</message>");
            output.AppendLine("<level>" + level + "</level>");
            output.AppendLine("<date>" + date + "</date>");
            output.AppendLine("</log>");

            return output.ToString();
        }
    }
}
