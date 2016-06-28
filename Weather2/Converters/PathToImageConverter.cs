using System;
using System.Globalization;
using Xamarin.Forms;

namespace Weather2
{
    public class PathToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                string path = value.ToString();

                if (path.Equals("http://openweathermap.org/img/w/02d.png"))
                {
                 path =("01d.png");
                }
                    
                ImageSource img = ImageSource.FromUri(new Uri(path));

                return img;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

