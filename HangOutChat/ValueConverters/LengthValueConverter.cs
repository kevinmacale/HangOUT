using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangOutChat.Word
{
    /// <summary>
    /// This will convert the value of desired field
    /// </summary>
    public class LengthValueConverter : BaseValueConverter<LengthValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int.TryParse((string)value, out int intValue);

            if (intValue == 0)
            {
                return true;
            }

            return false;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
