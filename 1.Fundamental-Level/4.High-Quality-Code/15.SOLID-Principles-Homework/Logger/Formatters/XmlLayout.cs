namespace Logger.Formatters
{
    using System;
    using System.Text;
    using Contracts;

    public class XmlLayout : ILayout
    {
        public string Format(DateTime date, ReportLevel level, string message)
        {
            var result = new StringBuilder();

            result.AppendLine("<log>");
            result.AppendLine($" <data>{level}</data>");
            result.AppendLine($" <level>{level}</level>");
            result.AppendLine($" <message>{message}</message>");
            result.AppendLine("</log>");

            return result.ToString();
        }
    }
}