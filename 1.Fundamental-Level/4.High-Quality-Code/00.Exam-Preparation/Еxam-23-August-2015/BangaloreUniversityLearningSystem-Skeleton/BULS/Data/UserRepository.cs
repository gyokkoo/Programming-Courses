namespace BULS.Data
{
    using System.Collections.Generic;

    using BULS.Models;

    public class UsersRepository : Repository<User>
    {
        private Dictionary<string, User> usersByUsername;

        public UsersRepository()
        {
            this.usersByUsername = new Dictionary<string, User>();
        }

        public User GetByUsername(string username)
        {
            if (!this.usersByUsername.ContainsKey(username))
            {
                return null;
            }

            return this.usersByUsername[username];

            // return this.Items.FirstOrDefault(u => u.Username == username);
        }

        public override void Add(User user)
        {
            base.Add(user);
            this.usersByUsername[user.Username] = user;
        }
    }
}
