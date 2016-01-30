namespace Logger.Appenders
{
    using System;

    using Contracts;

    public abstract class Appender : IAppender
    {
        private ILayout layout;

        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = 0;
        }

        public ILayout Layout
        {
            get
            {
                return this.layout;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        nameof(value),
                        "Layout cannot be null.");
                }

                this.layout = value;
            }
        }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(DateTime date, ReportLevel level, string message);
    }
}