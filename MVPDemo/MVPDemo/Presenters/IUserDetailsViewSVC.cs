using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVPDemo.Model;

namespace MVPDemo.Presenters
{
    public interface IUserDetailsViewSVC
    {
        IEnumerable<User> UserList { set; }
        string FirstName { set; }
        string LastName { set; }
        string Username { set; }
        string DateJoined { set; }
        string SelectedUsername { get; }
    }
}
