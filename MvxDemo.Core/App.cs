using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvxDemo.Core.Configuration.Startup;
using MvxDemo.Core.Infrastructure.Services;
using MvxDemo.Core.Infrastructure.Services.Interfaces;


namespace MvxDemo.Core
{
    //MvxApplication should be extended
    public class App : MvxApplication
    {
        private void ConfigureIoC()
        {
            Mvx.RegisterType<IAuthenticationService, AuthenticationService>();
        }

        public override void Initialize()
        {
            base.Initialize();

            ConfigureIoC();

            //We can change login sate to see control navigation flow:
            Mvx.Resolve<IAuthenticationService>().LoggedIn = false;

            //Register extended app startup in Iox container:
            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, MvxAppExtendedStart>();
            var appStart = Mvx.Resolve<IMvxAppStart>();

            //register tje appstart object:
            RegisterAppStart(appStart);
        }
    }
}
