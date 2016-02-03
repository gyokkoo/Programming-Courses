namespace HotelBookingSystem.Tests
{
    using HotelBookingSystem.Data;
    using HotelBookingSystem.Models;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RepositoryTests
    {
        private Repository<Venue> repository;

        [TestInitialize]
        public void SetUp()
        {
            this.repository = new Repository<Venue>();
        }

        [TestMethod]
        public void TestGet_NoItems_ShouldReturnNull()
        {
            var result = this.repository.Get(6);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestGet_ItemPresent_ShouldReturnItem()
        {
            var user = new User("Admin", "Admin123", Roles.VenueAdmin);
            this.repository.Add(new Venue("Venue1", "Sofiq", "nqma", user));
            this.repository.Add(new Venue("Venue2", "Sofiq", "nqma", user));
            this.repository.Add(new Venue("Venue3", "Sofiq", "nqma", user));

            var result = this.repository.Get(2);

            Assert.AreEqual("Venue2", result.Name);
        }

        [TestMethod]
        public void TestGet_ItemPresent_ShouldReturnItemAddress()
        {
            var user = new User("Admin", "Admin123", Roles.VenueAdmin);
            this.repository.Add(new Venue("Venue1", "Sofiq", "nqma", user));
            this.repository.Add(new Venue("Venue2", "Sofiq", "nqma", user));
            this.repository.Add(new Venue("Venue3", "Sofiq", "nqma", user));

            var result = this.repository.Get(2);

            Assert.AreEqual("Sofiq", result.Address);
        }

        [TestMethod]
        public void TestGet_ItemPresent_ShouldReturnItemDescription()
        {
            var user = new User("Admin", "Admin123", Roles.VenueAdmin);
            this.repository.Add(new Venue("Venue1", "Sofiq", "nqma", user));
            this.repository.Add(new Venue("Venue2", "Sofiq", "nqma", user));
            this.repository.Add(new Venue("Venue3", "Sofiq", "nqma", user));

            var result = this.repository.Get(2);

            Assert.AreEqual("nqma", result.Description);
        }

        [TestMethod]
        public void TestGet_ItemPresent_ShouldReturnItemId()
        {
            var user = new User("Admin", "Admin123", Roles.VenueAdmin);
            this.repository.Add(new Venue("Venue1", "Sofiq", "nqma", user));
            this.repository.Add(new Venue("Venue2", "Sofiq", "nqma", user));
            this.repository.Add(new Venue("Venue3", "Sofiq", "nqma", user));

            var result = this.repository.Get(2);

            Assert.AreEqual(2, result.Id);
        }
    }
}
