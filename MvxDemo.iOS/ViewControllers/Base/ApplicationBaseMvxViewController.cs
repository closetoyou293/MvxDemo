using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using MvvmCross.iOS.Views;
using MvxDemo.Core.ViewModels.Base;
using UIKit;

namespace MvxDemo.iOS.ViewControllers.Base
{
    public abstract class ApplicationBaseMvxViewController<TViewModel, TInitParams> : ApplicationBaseMvxViewController<TViewModel> where TViewModel : BaseApplicationMvxViewModel<TInitParams> where TInitParams : class 
    {

    }

    public abstract class ApplicationBaseMvxViewController<TViewModel> : MvxViewController<TViewModel>
        where TViewModel : BaseApplicationMvxViewModel
    {
        
    }
}