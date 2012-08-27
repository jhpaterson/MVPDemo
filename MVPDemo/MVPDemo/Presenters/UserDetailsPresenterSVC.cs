using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVPDemo.Model;

namespace MVPDemo.Presenters
{
    public class UserDetailsPresenterSVC
    {
        private IUserDetailsViewSVC view;
        private INavigator navigator;
        private UserRepository repository;

        public UserDetailsPresenterSVC(IUserDetailsViewSVC view, INavigator navigator)
        {
            this.view = view;
            this.navigator = navigator;
            repository = new UserRepository();
        }

        public void Initialize()
        {
            IQueryable<User> users = repository.GetAll();
            view.UserList = users;

            ClearView();
        }

        public void ShowUserDetails()
        {
            string username = view.SelectedUsername;
           
                User user = repository.GetByUsername(username);
                if (user != null)
                {
                    UpdateView(user);
                }

        }

        public void GoToHome()
        {
            navigator.NavigateTo("Default");
        }

        private void ClearView()
        {
            view.FirstName = String.Empty;
            view.LastName = String.Empty;
            view.Username = String.Empty;
            view.DateJoined= String.Empty;
        }

        private void UpdateView(User user)
        {
            view.FirstName = user.firstname;
            view.LastName = user.lastname;
            view.Username = user.username;
            view.DateJoined = String.Format("{0:d}",user.datejoined);
        }

    }
}