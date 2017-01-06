using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace _8.ElementBinding
{
    public class LoginMultiConverter:IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    return false;
            }
            if (values[1].ToString() == values[2].ToString())
            {
                return true;
            }
            return false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}