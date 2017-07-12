using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.iOS.Views.Presenters;
using UIKit;

namespace MvxDemo.iOS.Configuration.Presenters
{
    //Extend MvxIosViewPresenter so you do custom implementation
    public class MvxIosAppPresenter : MvxIosViewPresenter
    {
        public MvxIosAppPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }
    }
}