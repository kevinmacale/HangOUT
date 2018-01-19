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
    /// View model for Register screen
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {
        #region Private Member
        private bool _registerIsRunning;
        #endregion

        #region Public Properties
        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Flag indicating if the command is running
        /// </summary>
        public bool RegisterIsRunning
        {
            get { return _registerIsRunning; }
            set
            {
                _registerIsRunning = value;
                OnPropertyChanged("RegisterIsRunning");
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
        public RegisterViewModel()
        {
            InitializedCommands();
        }
        #endregion

        #region Private Method
        
        private void InitializedCommands()
        {
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync(parameter));
            LoginCommand = new RelayCommand(async () => await LoginAsync());
        }

        /// <summary>
        /// attempts to login
        /// </summary>
        /// <returns></returns>
        public async Task LoginAsync()
        {
            // todo: 
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPageEnum.Login);
            await Task.Delay(1);
        }

        /// <summary>
        ///  attempts to register the user end
        /// </summary> 
        /// <param name="parameter">secured string from view</param>
        /// <returns></returns>
        public async Task RegisterAsync(object parameter)
        {
            await RunCommandAsync(() => RegisterIsRunning, async () =>
            {
                await Task.Delay(5000);
                var sp = (parameter as IHavePassword).SecurePassword.Unsecure();
                var email = Email;
            });
        }

        #endregion
    }
}
