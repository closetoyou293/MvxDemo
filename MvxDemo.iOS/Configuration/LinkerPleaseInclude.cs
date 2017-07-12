using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Foundation;
using UIKit;

namespace MvxDemo.iOS.Configuration
{
    [Preserve(AllMembers = true)]
    public class LinkerPleaseInclude
    {

        LinkerPleaseInclude()
        {
            
        }

        public void Include(UIButton uiButton)
        {
            uiButton.TouchUpInside +=
                (s, e) => uiButton.SetTitle(uiButton.Title(UIControlState.Normal), UIControlState.Normal);
        }

        public void Include(ICommand command)
        {
            command.CanExecuteChanged += (s, e) =>
            {
                if (command.CanExecute(null))
                {
                    command.Execute(null);
                }
            };
        }

        public void Include(INotifyPropertyChanged changed)
        {
            changed.PropertyChanged += (sender, e) =>
            {
                var test = e.PropertyName;
            };
        }
    }
}