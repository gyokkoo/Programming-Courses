namespace HotelBookingSystem.Controllers
{
    using System;

    using Contracts;
    using Infrastructure;
    using Models;
    using Utilities;

    public class UsersController : Controller
    {
        public UsersController(IHotelBookingSystemData data, User user)
            : base(data, user)
        {
        }

        public IView Register(string username, string password, string confirmPassword, string role)
        {
            // Possible bottleneck
            this.ValidateUserExistence();

            var existingUser = this.Data.UsersRepository.GetByUsername(username);
            if (existingUser != null)
            {
                throw new ArgumentException(
                    $"A user with username {username} already exists.");
            }

            if (password != confirmPassword)
            {
                throw new ArgumentException(
                    "The provided passwords do not match.");
            }

            Roles userRole = (Roles)Enum.Parse(typeof(Roles), role, true);
            var user = new User(username, password, userRole);
            this.Data.UsersRepository.Add(user);

            return this.View(user);
        }

        public IView Login(string username, string password)
        {
            this.ValidateUserExistence();

            var existingUser = this.Data.UsersRepository.GetByUsername(username);
            if (existingUser == null)
            {
                throw new ArgumentException(
                    $"A user with username {username} does not exist.");
            }

            if (existingUser.PasswordHash != HashUtilities.GetSha256Hash(password))
            {
                throw new ArgumentException(
                    "The provided password is wrong.");
            }

            this.CurrentUser = existingUser;

            return this.View(existingUser);
        }

        public IView MyProfile()
        {
            this.Authorize(Roles.User, Roles.VenueAdmin);

            return this.View(this.CurrentUser);
        }

        public IView Logout()
        {
            this.Authorize(Roles.User, Roles.VenueAdmin);

            var user = this.CurrentUser;
            this.CurrentUser = null;

            return this.View(user);
        }

        private void ValidateUserExistence()
        {
            if (this.HasCurrentUser)
            {
                throw new ArgumentException("There is already a logged in user.");
            }
        }
    }
}
