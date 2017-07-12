using Cirrious.FluentLayouts.Touch;
using CoreGraphics;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views.Presenters.Attributes;
using MvxDemo.Core.ViewModels;
using MvxDemo.iOS.ViewControllers.Base;
using UIKit;

namespace MvxDemo.iOS.ViewControllers
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public class LoginViewController : ApplicationBaseMvxViewController<LoginViewModel>
    {
        private UIImageView _logoImage;
        private UITextField _loginTextField;
        private UITextField _passwordTextField;
        private UIButton _loginButton;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupView();
            SetupBinding();
        }

        private void SetupView()
        {
            NavigationController.SetNavigationBarHidden(true, true);

            View.BackgroundColor = UIColor.White;

            _logoImage = new UIImageView();
            _logoImage.Image = UIImage.FromBundle("login_logo");
            _logoImage.Frame = new CGRect(0, 0, _logoImage.Image.CGImage.Width, _logoImage.Image.CGImage.Height);
            _logoImage.ContentMode = UIViewContentMode.ScaleAspectFill;

            var firstAttributes = new UIStringAttributes
            {
                ForegroundColor = UIColor.FromRGB(36, 183, 128),
                Font = UIFont.FromName("ArialMT", 15f)
            };

            _loginTextField = new UITextField(new CGRect())
            {
                AttributedPlaceholder = new NSAttributedString("Username..."),
            };
            _loginTextField.TextColor = UIColor.FromRGB(36, 183, 128);
            _loginTextField.Font = UIFont.FromName("ArialMT", 15f);

            _passwordTextField = new UITextField(new CGRect())
            {
                AttributedPlaceholder = new NSAttributedString("Password...", firstAttributes),
                SecureTextEntry = true
            };
            _passwordTextField.TextColor = UIColor.FromRGB(36, 183, 128);
            _passwordTextField.Font = UIFont.FromName("ArialMT", 15f);

            _loginButton = new UIButton(UIButtonType.System);
            _loginButton.SetTitle("Login", UIControlState.Normal);
            _loginButton.Font = UIFont.FromName("ArialMT", 15f);
            _loginButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            _loginButton.Layer.BorderWidth = 1;
            _loginButton.Layer.CornerRadius = 10;
            _loginButton.Layer.BorderColor = UIColor.Black.CGColor;

            Add(_logoImage);
            Add(_loginTextField);
            Add(_passwordTextField);
            Add(_loginButton);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            View.AddConstraints(_logoImage.AtTopOf(View, 80),
                _logoImage.Height().EqualTo(90),
                _logoImage.Width().EqualTo(90),
                _logoImage.WithSameCenterX(View),
                _loginTextField.WithSameCenterX(View),
                _loginTextField.Below(_logoImage, 40),
                _loginTextField.AtLeftOf(View, 40),
                _loginTextField.AtRightOf(View, 40),
                _passwordTextField.WithSameCenterX(_loginTextField),
                _passwordTextField.Below(_loginTextField, 20),
                _passwordTextField.AtLeftOf(View, 40),
                _passwordTextField.AtRightOf(View, 40),
                _loginButton.WithSameCenterX(_passwordTextField),
                _loginButton.Below(_passwordTextField, 40),
                _loginButton.AtLeftOf(View, 40),
                _loginButton.AtRightOf(View, 40)

            );
        }

        private void SetupBinding()
        {
            var bindingSet = this.CreateBindingSet<LoginViewController, LoginViewModel>();

            bindingSet.Bind(_loginTextField).To(x => x.Username);
            bindingSet.Bind(_passwordTextField).To(x => x.Password);
            bindingSet.Bind(_loginButton).To(x => x.Login);
            bindingSet.Bind(_loginButton).For(x => x.Enabled).To(x => x.CanSignIn);
            bindingSet.Apply();
        }
    }
}