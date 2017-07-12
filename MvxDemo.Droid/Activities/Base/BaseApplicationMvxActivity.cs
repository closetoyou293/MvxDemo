using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvxDemo.Core.ViewModels.Base;

namespace MvxDemo.Droid.Activities.Base
{
    public abstract class BaseApplicationMvxActivity<TViewMOdel, TInitParams> : BaseApplicationMvxActivity<TViewMOdel> where TViewMOdel : BaseApplicationMvxViewModel where TInitParams : class 
    {
    }

    public abstract class BaseApplicationMvxActivity<TViewModel> : MvxAppCompatActivity<TViewModel>
        where TViewModel : BaseApplicationMvxViewModel
    {
        public abstract int LayoutId { get; }
        public virtual int LayoutRootId => Resource.Id.Layout;

        protected override void OnCreate(Bundle bundle)
        {
            var setup = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
            setup.EnsureInitialized();
            base.OnCreate(bundle);
            SetContentView(LayoutId);
        }
    }
}