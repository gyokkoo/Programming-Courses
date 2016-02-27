namespace _19.ChatLogger
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Security;
    using System.Text.RegularExpressions;
    using System.Threading;

    public class ChatLogger
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            var chatLogger = new SortedDictionary<DateTime, string>();

            DateTime currentDate = DateTime.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            while (line != null && line != "END")
            {
                string[] lineArgs = Regex.Split(line, @"\s+\/\s+");
                string message = lineArgs[0].Trim();
                DateTime msgTime = DateTime.Parse(lineArgs[1].Trim());
                chatLogger.Add(msgTime, message);

                line = Console.ReadLine();
            }

            DateTime lastMsgDate = new DateTime();
            foreach (var currentChat in chatLogger)
            {
                Console.WriteLine("<div>{0}</div>", SecurityElement.Escape(currentChat.Value));
                lastMsgDate = currentChat.Key;
            }

            TimeSpan timeSpan = currentDate - lastMsgDate;
            if (currentDate.Day == lastMsgDate.Day)
            {
                if (currentDate.Hour == lastMsgDate.Hour && timeSpan.Minutes < 1)
                {
                    Console.WriteLine("<p>Last active: <time>a few moments ago</time></p>");
                }
                else if (timeSpan.Hours < 1)
                {
                    Console.WriteLine("<p>Last active: <time>{0} minute(s) ago</time></p>", timeSpan.Minutes);
                }
                else
                {
                    Console.WriteLine("<p>Last active: <time>{0} hour(s) ago</time></p>", timeSpan.Hours);
                }
            }
            else if (currentDate.Month == lastMsgDate.Month && timeSpan.Days <= 1)
            {
                Console.WriteLine("<p>Last active: <time>yesterday</time></p>");
            }
            else
            {
                Console.WriteLine("<p>Last active: <time>{0}</time></p>", lastMsgDate.ToString("dd-MM-yyyy"));
            }
        }
    }
}
