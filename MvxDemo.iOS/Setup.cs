using System;
using System.Collections.Generic;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using MvxDemo.Core;
using UIKit;

namespace MvxDemo.iOS
{
    // MvxIosSetup should be extended:
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
               : base(applicationDelegate, window)
        {
        }

        protected override IMvxApplication CreateApp() => new App();
    }
}
