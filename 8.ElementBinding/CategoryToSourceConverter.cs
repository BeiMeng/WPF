using System;
using System.Globalization;
using System.Windows.Data;

namespace _8.ElementBinding
{
    /// <summary>
    /// 将飞机的分类转换成显示不同类型飞机的图片的 url地址
    /// </summary>
    public class CategoryToSourceConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Category c = (Category) value;
            switch (c)
            {
                case Category.Bomber:
                    return @"\Icons\ad.png";
                case Category.Fighter:
                    return @"\Icons\ae.png";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}