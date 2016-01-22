namespace Exceptions_Homework
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Grade = grade;
            this.Comments = comments;
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "The minimum grade cannot be less than zero.");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value < this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "The maximum grade cannot be less than minimum grade.");
                }

                this.maxGrade = value;
            }
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (this.MinGrade > value && value > this.MaxGrade)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "The grade cannot be less than minimum grade and bigger than maximum grade.");
                }

                this.grade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        nameof(value),
                        "The comments section cannot be empty or white space.");
                }

                this.comments = value;
            }
        }
    }
}
