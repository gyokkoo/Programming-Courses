namespace HotelBookingSystem.Views.Users
{
    using System.Text;

    using HotelBookingSystem.Infrastructure;
    using HotelBookingSystem.Models;

    public class Logout : View
    {
        public Logout(User user)
            : base(user)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var user = this.Model as User;
            viewResult.AppendFormat("The user {0} has logged out.", user.Username).AppendLine();
        }
    }
}