namespace BULS.Tests
{
    using System.Collections.Generic;

    using BULS.Contracts;
    using BULS.Data;
    using BULS.Models;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RepositoryTests
    {
        private IRepository<User> users;

        [TestInitialize]
        public void InitializeRepository()
        {
            this.users = new Repository<User>();
        }

        [TestMethod]
        public void Get_ValidId_ShouldReturnElement()
        {
            const int Id = 1;
            var userList = new List<User>()
                               {
                                   new User("Pesho", "123456", Role.Lecturer),
                                   new User("Gosho", "321126", Role.Student)
                               };

            foreach (User user in userList)
            {
                this.users.Add(user);
            }

            var actualUser = this.users.Get(Id);

            Assert.AreEqual(userList[Id - 1], actualUser);
        }

        [TestMethod]
        public void Get_InValidId_EmptyList_ShouldReturnDefaultUser()
        {
            const int Id = 1;

            var actualUser = this.users.Get(Id);

            Assert.AreEqual(default(User), actualUser);
        }

        [TestMethod]
        public void Get_InValidId_NonEmptyList_ShouldReturnDefaultUser()
        {
            var userList = new List<User>()
                               {
                                   new User("Pesho", "123456", Role.Lecturer),
                                   new User("Gosho", "321126", Role.Student)
                               };

            int id = userList.Count + 1;

            foreach (User user in userList)
            {
                this.users.Add(user);
            }

            var actualUser = this.users.Get(id);

            Assert.AreEqual(default(User), actualUser);
        }
    }
}