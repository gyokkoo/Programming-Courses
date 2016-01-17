namespace Exceptions_Homework
{
    using System;

    public class SimpleMathExam : Exam
    {
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

            set
            {
                if (value < 0 || 10 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The numbers of problem solved must be in range [0..10]");
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            switch (this.ProblemsSolved)
            {
                case 0:
                    return new ExamResult(2, 2, 6, "Bad result: nothing done.");
                case 1:
                    return new ExamResult(4, 2, 6, "Average result: nothing done.");
                case 2:
                    return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }

            return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}
