namespace BULS.Views.Courses
{
    using System;
    using System.Text;

    using Models;

    public class Create : View
    {
        public Create(Course course)
            : base(course)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var course = this.Model as Course;

            viewResult.AppendFormat(
                "Course {0} created successfully.{1}",
                course.Name,
                Environment.NewLine);
        }
    }
}