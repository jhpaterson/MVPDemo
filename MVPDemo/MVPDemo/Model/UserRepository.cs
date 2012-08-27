using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPDemo.Model
{
    public class UserRepository
    {
        private gcutoursEntities context = new gcutoursEntities();

        public IQueryable<User> GetAll()
        {
            return context.Users;
        }

        public User GetByUsername(string target)
        {
            return context.Users.SingleOrDefault(u => u.username == target);
        }
    }
}
