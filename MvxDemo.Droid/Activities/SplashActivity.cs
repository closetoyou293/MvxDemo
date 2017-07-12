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
using MvvmCross.Droid.Views;

namespace MvxDemo.Droid.Activities
{
    [Register("com.mvxdemo.activities.SplashActivity")]
    [Activity(Label = "SplashActivity", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : MvxSplashScreenActivity
    {
        public SplashActivity() : base(Resource.Layout.SplashScreen)
        {
            
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }

        protected override void OnPause()
        {
            base.OnPause();
            OverridePendingTransition(0,0);
        }

    }
}