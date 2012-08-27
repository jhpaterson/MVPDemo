using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPDemo.Model
{
    public partial class User
    {
        public string FullName
        {
            get { return String.Format("{0} {1}", firstname, lastname); }
        }
    }
}