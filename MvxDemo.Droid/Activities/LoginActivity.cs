using Android.App;
using Android.Content.PM;
using Android.Runtime;
using MvxDemo.Droid.Activities.Base;
using MvxDemo.Core.ViewModels;

namespace MvxDemo.Droid.Activities
{
    [Activity(ClearTaskOnLaunch = true, LaunchMode = LaunchMode.SingleTask)]
    [Register("com.mvx.demo.activities.LoginActivity")]
    public class LoginActivity : BaseApplicationMvxActivity<LoginViewModel>
    {
        public override int LayoutId => Resource.Layout.LoginActivity;
        public LoginActivity()
        {
            
        }
    }
}