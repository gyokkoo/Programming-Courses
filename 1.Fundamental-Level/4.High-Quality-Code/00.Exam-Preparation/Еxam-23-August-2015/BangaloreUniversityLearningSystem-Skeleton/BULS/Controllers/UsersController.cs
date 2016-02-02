namespace BULS.Controllers
{
    using System;

    using Contracts;

    using Exceptions;
    using Models;
    using Utilities;

    public class UsersController : Controller
    {
        public UsersController(IBangaloreUniversityData data, User currentUser)
        {
            this.Data = data;
            this.CurrentUser = currentUser;
        }

        public IView Register(
            string username,
            string password,
            string confirmPassword,
            string role)
        {
            if (password != confirmPassword)
            {
                throw new ArgumentException("The provided passwords do not match.");
            }

            this.EnsureNoLoggedInUser();

            var existingUser = this.Data.Users.GetByUsername(username);

            if (existingUser != null)
            {
                throw new ArgumentException(
                    $"A user with username {username} already exists.");
            }

            Role userRole = (Role)Enum.Parse(typeof(Role), role, true);
            var user = new User(username, password, userRole);
            this.Data.Users.Add(user);

            return this.View(user);
        }

        public IView Login(string username, string password)
        {
            this.EnsureNoLoggedInUser();

            var existingUser = this.Data.Users.GetByUsername(username);

            if (existingUser == null)
            {
                throw new ArgumentException(
                    $"A user with username {username} does not exist.");
            }

            if (existingUser.Password != HashUtilities.HashPassword(password))
            {
                throw new ArgumentException("The provided password is wrong.");
            }

            this.CurrentUser = existingUser;

            return this.View(existingUser);
        }

        public IView Logout()
        {
            if (!this.HasCurrentUser)
            {
                throw new ArgumentException("There is no currently logged in user.");
            }

            if (!this.CurrentUser.IsInRole(Role.Lecturer) && !this.CurrentUser.IsInRole(Role.Student))
            {
                throw new AuthorizationFailedException(
                    "The current user is not authorized to perform this operation.");
            }

            var user = this.CurrentUser;

            this.CurrentUser = null;

            return this.View(user);
        }

        private void EnsureNoLoggedInUser()
        {
            if (this.HasCurrentUser)
            {
                throw new ArgumentException("There is already a logged in user.");
            }
        }
    }
}