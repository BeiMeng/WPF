using System.Globalization;
using System.Windows.Controls;

namespace _8.ElementBinding
{
    public class RangeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double d = 0;
            if (double.TryParse(value.ToString(), out d))
            {
                if (d>=0 && d<=100)
                {
                    return new ValidationResult(true,null);
                }
            }
            return new ValidationResult(false,"只能输入0到100的数字");
        }
    }
}