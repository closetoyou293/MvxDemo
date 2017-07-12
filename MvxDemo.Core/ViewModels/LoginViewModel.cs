using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvxDemo.Core.Models;
using MvxDemo.Core.ViewModels.Base;

namespace MvxDemo.Core.ViewModels
{
    public class LoginViewModel : BaseApplicationMvxViewModel
    {
        private string _userName;

        public string Username
        {
            get => _userName;
            set {if (SetProperty(ref _userName, value))
                    RaisePropertyChanged(nameof(CanSignIn)); }
        }

        private string _password;

        public string Password
        {
            get => _password;
            set {if (SetProperty(ref _password, value))
                    RaisePropertyChanged(nameof(CanSignIn)); }
        }

        public IMvxCommand Login => new MvxCommand(async ()=> await SignInAsync());
        public bool CanSignIn => !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);

        async Task SignInAsync()
        {
            System.Diagnostics.Debug.WriteLine("Sign in CLICKED");
            var userData = new UserData()
            {
                Name = Username
            };
            await Navigate<HomeViewModel, UserData>(userData);
        }

        public LoginViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
    }
}