namespace Exceptions_Homework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 10;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < MinScore || MaxScore < value)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        $"The solved problems must be between {MinScore} and {MaxScore}");
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            switch (this.ProblemsSolved)
            {
                case 0:
                case 1:
                case 2:
                    return new ExamResult(2, 2, 6, "Bad result: nothing done.");
                case 3:
                case 4:
                    return new ExamResult(3, 2, 6, "Middle result: only few done.");
                case 5:
                case 6:
                    return new ExamResult(4, 2, 6, "Good result: nothing done.");
                case 7:
                case 8:
                    return new ExamResult(5, 2, 6, "Very good result: most of tasks done.");
                case 9:
                case 10:
                    return new ExamResult(6, 2, 6, "Excelent result: everything is done.");
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(ProblemsSolved),
                        $"The solved problems must be between {MinScore} and {MaxScore}.");
            }
        }
    }
}
