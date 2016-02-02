namespace BULS.Tests
{
    using System;
    using System.Linq;

    using BULS.Contracts;
    using BULS.Controllers;
    using BULS.Models;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    [TestClass]
    public class CoursesTests
    {
        private IBangaloreUniversityData mockedData;
        private Course course;

        [TestInitialize]
        public void InitializeMocks()
        {
            var dataMock = new Mock<IBangaloreUniversityData>();
            var courseRepoMock = new Mock<IRepository<Course>>();
            this.course = new Course("C# for babies");

            courseRepoMock.Setup(r => r.Get(It.IsAny<int>())).Returns(this.course);
            dataMock.Setup(d => d.Courses).Returns(courseRepoMock.Object);

            this.mockedData = dataMock.Object;
        }

        [TestMethod]
        public void AddLecture_ValidCourseId_ShouldAddToCourse()
        {
            string lectureName = DateTime.Now.ToString();

            var controller = new CoursesController(
                this.mockedData,
                new User("Pesho", "123456", Role.Lecturer));

            var view = controller.AddLecture(5, lectureName);

            Assert.AreEqual(this.course.Lectures.First().Name, lectureName);
            Assert.IsNotNull(view);
        }
    }
}