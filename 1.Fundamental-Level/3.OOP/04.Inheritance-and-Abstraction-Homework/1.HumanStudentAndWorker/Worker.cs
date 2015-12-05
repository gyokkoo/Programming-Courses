using System;

namespace _1.HumanStudentAndWorker
{
    public class Worker : Human
    {
        public const int WorkingDaysOfWeek = 5;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public decimal WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (WorkingDaysOfWeek * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return String.Format("{0} {1} makes per hour {2:F2} leva",
                this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
