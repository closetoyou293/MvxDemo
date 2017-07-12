

using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvxDemo.Core.ViewModels;
using MvxDemo.Droid.Activities.Base;

namespace MvxDemo.Droid.Activities
{
    [Register("com.mvxdemo.activities.MainActivity")]
    [Activity(Label = "MainActivity")]
    public class MainActivity : BaseApplicationMvxFramentActivity<MainViewModel>
    {
        public override int LayoutId => Resource.Layout.MainActivity;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var myToolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(myToolbar);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Android.Resource.Id.Home)
            {
                OnBackPressed();
                return true;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}