namespace Application2
{
    using System;

    public class Score
    {
        private const string DefaultPlayerName = "Player";
        private const int DefaultPlayerScore = 0;

        private string name;
        private int points;

        public Score(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public Score()
            : this(DefaultPlayerName, DefaultPlayerScore)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(name), "Name name cannot be null or whitespace.");
                }

                this.name = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(points), "Points cannot be negative.");
                }

                this.points = value;
            }
        }
    }
}
