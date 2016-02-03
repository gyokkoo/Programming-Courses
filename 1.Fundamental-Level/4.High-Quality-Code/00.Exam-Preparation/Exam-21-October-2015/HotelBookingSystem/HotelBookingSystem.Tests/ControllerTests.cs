namespace HotelBookingSystem.Tests
{
    using System;
    using System.Text;

    using HotelBookingSystem.Contracts;
    using HotelBookingSystem.Controllers;
    using HotelBookingSystem.Data;
    using HotelBookingSystem.Identity;
    using HotelBookingSystem.Infrastructure;
    using HotelBookingSystem.Models;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAuthorize_NoLoggedUser_ShouldThrow()
        {
            var db = new HotelBookingSystemData();
            var controller = new VenuesController(db, null);

            controller.Details(1);
        }

        [TestMethod]
        [ExpectedException(typeof(AuthorizationFailedException))]
        public void TestAuthorize_NoSufficientRights_ShouldThrow()
        {
            var db = new HotelBookingSystemData();
            var controller = new VenuesController(db, new User("Pesho", "123456", Roles.User));

            controller.Add("Test", "Sofiq", "no description");
        }

        [TestMethod]
        public void TestAuthorize_ValidUser_ShouldPass()
        {
            var db = new HotelBookingSystemData();
            var controller = new VenuesController(db, new User("Pesho", "1234567", Roles.VenueAdmin));

            controller.Add("Test123", "Sofiq city", "no description");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLogout_WithoutLoggedUser_ShouldThrow()
        {
            var db = new HotelBookingSystemData();
            var controller = new UsersController(db, null);

            controller.Logout();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLogout_WithLoggedUser_CurrentUserIsNull()
        {
            var db = new HotelBookingSystemData();
            var controller = new UsersController(db, null);

            controller.Logout();
            var user = controller.CurrentUser;
            Assert.IsNull(user);
        }

        [TestMethod]
        public void TestAllVenues_WithoutVenues_CorrectReturnString()
        {
            const string expected = "There are currently no venues to show.";

            var db = new HotelBookingSystemData();
            var controller = new VenuesController(db, null);
            var result = controller.All().Display();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAllVenues_WithVenues_CorrectReturnString()
        {
            var resultString = new StringBuilder();
            resultString.AppendLine("*[1] New venue, located at Sofia");
            resultString.AppendLine("Free rooms: 0");
            resultString.AppendLine("*[2] New venue 2, located at Sofia");
            resultString.Append("Free rooms: 0");

            var db = new HotelBookingSystemData();
            var user = new User("Pesho", "1234567", Roles.VenueAdmin);
            var controller = new VenuesController(db, user);

            controller.Add("New venue", "Sofia", "");
            controller.Add("New venue 2", "Sofia", "");

            var result = controller.All().Display();

            Assert.AreEqual(resultString.ToString(), result);
        }
    }
}