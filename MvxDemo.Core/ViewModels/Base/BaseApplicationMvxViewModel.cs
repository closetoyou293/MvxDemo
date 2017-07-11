using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvxDemo.Core.ViewModels.Interfaces;

namespace MvxDemo.Core.ViewModels.Base
{
    public abstract class BaseApplicationMvxViewModel : MvxViewModel, IBaseApplicationMvxViewModel
    {
        public Task Navigate<TViewModel>() where TViewModel : IMvxViewModel
        {
            throw new NotImplementedException();
        }

        public Task Navigate<TViewModel, TParameter>(TParameter param) where TViewModel : IMvxViewModel<TParameter> where TParameter : class
        {
            throw new NotImplementedException();
        }

        public bool PresentationChanged(MvxPresentationHint presentationHint)
        {
            throw new NotImplementedException();
        }

        public Task Close()
        {
            throw new NotImplementedException();
        }
    }
}
