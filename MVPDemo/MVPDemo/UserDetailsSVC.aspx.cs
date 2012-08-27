using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVPDemo.Presenters;
using MVPDemo.Model;

namespace MVPDemo
{
    public partial class UserDetailsSVC : System.Web.UI.Page, IUserDetailsViewSVC
    {
        private UserDetailsPresenterSVC presenter;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            presenter = new UserDetailsPresenterSVC(this, new PageNavigator());
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

        #region IUserDetailsViewSVC Members

        public IEnumerable<User> UserList {
            set 
            { 
                UsersDropDownList.DataSource=value;
                UsersDropDownList.DataValueField = "username";
                UsersDropDownList.DataTextField = "FullName";
                UsersDropDownList.DataBind();
            }
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