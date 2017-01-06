using System;
using System.Windows.Data;

namespace WpfCRUDDemo.ValueConverter
{
    [ValueConversion(typeof(int), typeof(string))]
    public class SexValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string sex = "";
            if (int.Parse(value.ToString()) == 0)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            return sex;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}