namespace BULS.Views.Users
{
    using System;
    using System.Text;

    using Models;

    public class Logout : View
    {
        public Logout(User user)
            : base(user)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var userModel = this.Model as User;

            viewResult.AppendFormat(
                "User {0} logged out successfully.{1}", 
                userModel.Username, 
                Environment.NewLine);
        }
    }
}
