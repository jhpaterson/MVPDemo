using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVPDemo.Presenters;

namespace MVPDemo
{
    public partial class UserDetails : System.Web.UI.Page, IUserDetailsView
    {
        private UserDetailsPresenter presenter;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            presenter = new UserDetailsPresenter(this, new PageNavigator());
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                presenter.Initialize();
            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.ShowUserDetails();
        }

        #region IUserDetailsView Members

        public void AddUser(string firstName, string lastName, string username)
        {
            ListItem item = new ListItem();
            item.Text = String.Format("{0} {1}", firstName, lastName);
            item.Value = username;
            this.UsersDropDownList.Items.Add(item);
        }

        public string FirstName
        {
            set { FirstNameLabel.Text = value; }
        }

        public string LastName
        {
            set { LastNameLabel.Text = value; }
        }

        public string Username
        {
            set { UsernameLabel.Text = value; }
        }

        public string DateJoined
        {
            set { DateJoinedLabel.Text = value; }
        }

        public string SelectedUsername
        {
            get { return UsersDropDownList.SelectedItem.Value; }
        }

        #endregion

        protected void UsersDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.ShowUserDetails();
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            presenter.GoToHome();
        }

    }
}