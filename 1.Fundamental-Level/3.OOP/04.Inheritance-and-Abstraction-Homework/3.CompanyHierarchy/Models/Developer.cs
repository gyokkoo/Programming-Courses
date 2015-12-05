using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.CompanyHierarchy
{
    class Developer : RegularEmployee
    {
        private List<Project> projects;

        public Developer(uint id, string firstName, string lastName, decimal salary, DepartmentType department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.projects = new List<Project>();
        }

        public List<Project> Projects
        {
            get
            {
                return this.projects;
            }
        }

        public void CloseProject(Project project)
        {
            bool containsProject = this.projects
                .Any(pr => pr == project);

            if(!containsProject)
            {
                throw new ArgumentException("Project is not part of this developer's project");
            }

            project.IsOpen = false;
        }

        public override string ToString()
        {
            return String.Format("ID {0} -> {1} {2} {3} has salary {4}",
                this.Id, this.GetType().Name, this.FirstName, this.LastName, this.Salary);
        }
    }
}
