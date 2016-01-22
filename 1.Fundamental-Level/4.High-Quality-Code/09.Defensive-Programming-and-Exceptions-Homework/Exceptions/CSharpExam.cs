namespace Exceptions_Homework
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MinScore || MaxScore < value)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        $"The exam score should be between {MinScore} and {MaxScore}.");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");
        }
    }
}