using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvxDemo.Core.Models;
using MvxDemo.Core.ViewModels.Base;

namespace MvxDemo.Core.ViewModels
{
    public class HomeViewModel : BaseApplicationMvxViewModel<UserData>
    {
        private string _userName;

        public string Username
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        
        public IMvxCommand ShowDetails => new MvxCommand(async () => { await Navigate<DetailsViewModel>(); });

        public HomeViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }

        public override Task Initialize(UserData userData)
        {
            Username = userData.Name;
            return base.Initialize(userData);
        }
    }
}
