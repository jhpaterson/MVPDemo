using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPDemo.Presenters
{
    public interface IUserDetailsView
    {
        void AddUser(string firstName, string lastName, string username);
        string FirstName { set; }
        string LastName { set; }
        string Username { set; }
        string DateJoined { set; }
        string SelectedUsername { get; }
    }
}