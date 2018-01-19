using HangOutChat.Word.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangOutChat.Word
{
    /// <summary>
    /// Converts the Application page enum to a actual view
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // find the appropriate page
            switch ((ApplicationPageEnum)value)
            {
                case ApplicationPageEnum.Login:
                    return new LoginPage();
                case ApplicationPageEnum.Chat:
                    return new ChatPage();
                case ApplicationPageEnum.Register:
                    return new RegisterPage();
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
