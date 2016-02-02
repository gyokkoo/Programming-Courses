namespace BULS
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using Contracts;

    public class Route : IRoute
    {
        public Route(string routeUrl)
        {
            this.Parse(routeUrl);
        }

        public string ActionName { get; private set; }

        public string ControllerName { get; private set; }

        public IDictionary<string, string> Parameters { get; private set; }

        private void Parse(string routeUrl)
        {
            string[] parts = routeUrl.Split(
                new[] { "/", "?" },
                StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2)
            {
                throw new InvalidOperationException(
                    "The provided route is invalid.");
            }

            this.ControllerName = parts[0] + "Controller";
            this.ActionName = parts[1];

            if (parts.Length >= 3)
            {
                this.Parameters = new Dictionary<string, string>();
                string[] parameterPairs = parts[2].Split('&');

                foreach (var pair in parameterPairs)
                {
                    string[] data = pair.Split('=');
                    string key = WebUtility.UrlDecode(data[0]);
                    string value = WebUtility.UrlDecode(data[1]);

                    this.Parameters.Add(key, value);
                }
            }
        }
    }
}