using System;

namespace _3.CompanyHierarchy
{
    public class Project
    {
        public Project(string name, DateTime? startDate, string details, bool isOpen)
        {
            this.Name = name;
            this.StartTime = startDate;
            this.Details = details;
            this.IsOpen = isOpen;
        }

        public string Name { get; set; }

        public DateTime? StartTime { get; set; }

        public string Details { get; set; }

        public bool IsOpen { get; set; }
    }
}
