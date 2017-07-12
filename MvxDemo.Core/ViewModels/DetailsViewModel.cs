using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvxDemo.Core.ViewModels.Base;

namespace MvxDemo.Core.ViewModels
{
    public class DetailsViewModel : BaseApplicationMvxViewModel
    {
        public IMvxCommand Dismiss => new MvxCommand(async ()=> await Close());

        public DetailsViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
    }
}
