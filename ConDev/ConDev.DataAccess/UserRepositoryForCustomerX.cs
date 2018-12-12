using System.Collections.Generic;
using System.Linq;
using ConDev.Logic;

namespace ConDev.DataAccess
{
    public class UserRepositoryForCustomerX : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public User Insert(User user)
        {
            _users.Add(user);
            return user;
        }

        public bool EmailExists(string email)
        {
            if (_users.Any(z => z.Email == email)) //TODO
            {
                return true;
            }
            return false;
        }
    }
}