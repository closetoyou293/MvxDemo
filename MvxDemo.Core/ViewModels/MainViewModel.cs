using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvxDemo.Core.ViewModels.Base;

namespace MvxDemo.Core.ViewModels
{
    public class MainViewModel : BaseApplicationMvxViewModel
    {
        public MainViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
    }
}
