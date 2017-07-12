using Android.OS;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvxDemo.Core.ViewModels.Base;

namespace MvxDemo.Droid.Activities.Base
{
    public abstract class BaseApplicationMvxFragmentActivity<TViewModel, TInitParams> : BaseApplicationMvxFramentActivity<TViewModel> where TViewModel : BaseApplicationMvxViewModel where TInitParams : class
    {
    }

    public abstract class BaseApplicationMvxFramentActivity<TViewModel> : MvxCachingFragmentCompatActivity<TViewModel>
        where TViewModel : BaseApplicationMvxViewModel
    {
        public abstract int LayoutId { get; }
        public virtual int LayoutRootId => Resource.Id.LayoutRoot;

        protected override void OnCreate(Bundle bundle)
        {
            var setup = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
            setup.EnsureInitialized();
            base.OnCreate(bundle);
            SetContentView(LayoutId);
        }
    }
}