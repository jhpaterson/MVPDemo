using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPDemo.Presenters
{
    public class PageNavigator : INavigator
    {
        #region INavigator Members

        public void NavigateTo(String viewName)
        {
            String page = String.Format("/{0}.aspx", viewName);  // very simplistic - no attempt to form URL properly
            HttpContext.Current.Response.Redirect(page);
        }

        #endregion
    }
}