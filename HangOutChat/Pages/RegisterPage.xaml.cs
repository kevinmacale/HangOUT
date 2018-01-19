
using HangOutChat.Word.Core;
using System.Security;

namespace HangOutChat.Word
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : BasePage<RegisterViewModel>, IHavePassword
    {
        public RegisterPage() => InitializeComponent();

        /// <summary>
        /// The secure password for this log in page
        /// </summary>
        public SecureString SecurePassword => pwBox.SecurePassword;
    }
}
