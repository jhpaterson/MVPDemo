using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPDemo.Presenters
{
    public interface INavigator
    {
        void NavigateTo(string viewName);
    }
}
