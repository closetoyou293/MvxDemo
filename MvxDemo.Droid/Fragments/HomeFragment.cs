
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvxDemo.Core.Models;
using MvxDemo.Core.ViewModels;
using MvxDemo.Droid.Fragments.Base;

namespace MvxDemo.Droid.Fragments
{
    [Register("com.mvxdemo.fragments.HomeFragment")]
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    public class HomeFragment : BaseMvxFragment<HomeViewModel, UserData>
    {
        protected override int FragmentId => Resource.Layout.HomeFragment;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var parentActivity = (MvxAppCompatActivity)Activity;
            parentActivity.SupportActionBar.Title = Resources.GetString(Resource.String.HomeFragmentTitle);
            parentActivity.SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            parentActivity.SupportActionBar.SetDisplayShowHomeEnabled(false);
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

    }
}