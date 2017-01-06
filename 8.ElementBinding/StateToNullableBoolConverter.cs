using System;
using System.Globalization;
using System.Windows.Data;

namespace _8.ElementBinding
{
    public class StateToNullableBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            State c = (State)value;
            switch (c)
            {
                case State.Locked:
                    return false;
                case State.Available:
                    return true;
                case State.UnKnown:
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? nb = (bool?) value;
            switch (nb)
            {
                case false:
                    return State.Locked;
                case true:
                    return State.Available;
                case null:
                default:
                    return State.UnKnown;
            }

        }
    }
}