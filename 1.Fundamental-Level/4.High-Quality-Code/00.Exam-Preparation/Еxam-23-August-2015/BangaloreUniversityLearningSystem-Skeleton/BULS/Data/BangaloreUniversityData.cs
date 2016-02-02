namespace BULS.Data
{
    using BULS.Contracts;
    using BULS.Models;

    public class BangaloreUniversityData : IBangaloreUniversityData
    {
        public BangaloreUniversityData()
        {
            this.Users = new UsersRepository();
            this.Courses = new Repository<Course>();
        }

        public UsersRepository Users { get; private set; }

        public IRepository<Course> Courses { get; private set; }
    }
}
