using System;
using System.Drawing;
using System.IO;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfCRUDDemo.ValueConverter
{
    [ValueConversion(typeof(byte[]), typeof(ImageSource))]
    public class ImageToByteValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            byte[] binaryimagedata = value as byte[];
            if (binaryimagedata == null) return "";
            using (Stream imageStreamSource = new MemoryStream(binaryimagedata, false))
            {

                JpegBitmapDecoder jpeDecoder = new JpegBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                ImageSource imageSource = jpeDecoder.Frames[0];
                return imageSource;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return "";
            string path = value.ToString().Substring(8, value.ToString().Length - 8);
            Bitmap bitmap;
            BitmapSource bmp = new BitmapImage(new Uri(path, UriKind.Absolute));
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();

                enc.Frames.Add(BitmapFrame.Create(bmp));
                enc.Save(outStream);
                bitmap = new Bitmap(outStream);
            }
            Bitmap bm = new Bitmap(bitmap);

            MemoryStream stream = new MemoryStream();
            bm.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imgBytes = stream.ToArray();
            stream.Close();


            return imgBytes;
        }
    }
}