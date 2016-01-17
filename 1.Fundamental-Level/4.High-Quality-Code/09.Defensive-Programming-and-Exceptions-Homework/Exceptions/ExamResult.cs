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

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < this.MinGrade || this.MaxGrade < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The grade must in range of min grade and max grade.");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The min grade cannot be negative.");
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
                if (value <= this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The max grade cannot be less than min grade.");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "The comments section cannot be null or empty.");
                }

                this.comments = value;
            }
        }
    }
}
