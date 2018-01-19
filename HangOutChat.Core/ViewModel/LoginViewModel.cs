using HangOutChat.Core;
using HangOutChat.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HangOutChat.Word.Core
{
    /// <summary>
    /// View model for Login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Private Member
        private bool _loginIsRunning;
        #endregion

        #region Public Properties
        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Flag indicating if the command is running
        /// </summary>
        public bool LoginIsRunning
        {
            get { return _loginIsRunning; }
            set
            {
                _loginIsRunning = value;
                OnPropertyChanged("LoginIsRunning");
            }
        } 
        #endregion

        #region Command
        /// <summary>
        /// Command to Login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// Command to Register
        /// </summary>
        public ICommand RegisterCommand { get; set; }
        
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for main windows view model
        /// </summary>
        public LoginViewModel()
        {
            InitializedCommands();
        }
        #endregion

        #region Private Method
        
        private void InitializedCommands()
        {
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));
            RegisterCommand = new RelayCommand(async () => await RegisterAsync());
        }

        /// <summary>
        /// attempts to register
        /// </summary>
        /// <returns></returns>
        public async Task RegisterAsync()
        {
            //IoC.Get<ApplicationViewModel>().SlideMenuVisible ^= true;
            //return;
            // todo: 
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPageEnum.Register);
            //(Application.Current.MainWindow.DataContext as WindowsViewModel).CurrentPage = ApplicationPageEnum.Register;
            await Task.Delay(1);
        }

        /// <summary>
        ///  attempts to log the user end
        /// </summary> 
        /// <param name="parameter">secured string from view</param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {
            await RunCommandAsync(() => LoginIsRunning, async () =>
            {
                await Task.Delay(5000);

                // go to chat page
                IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPageEnum.Chat);

                // IMPORTANT:
                //var sp = (parameter as IHavePassword).SecurePassword.Unsecure();
                //var email = Email;
                //var ss = (parameter as LoginPage).AnimateOut();
            });
        }

        #endregion
    }
}
