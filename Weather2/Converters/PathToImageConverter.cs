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
                #region icons

                if ((path.Equals("http://openweathermap.org/img/w/01d.png")))
                {
                    path = ("sunny-1.png");
                }

                if ((path.Equals("http://openweathermap.org/img/w/01n.png")))
                {
                    path = ("night.png");
                }

                if ((path.Equals("http://openweathermap.org/img/w/02d.png")))
                {
                    path = ("cloud-1.png");
                }

                if ((path.Equals("http://openweathermap.org/img/w/02n.png")))
                {
                    path = ("night-1.png");
                }

                if ((path.Equals("http://openweathermap.org/img/w/03d.png") || (path.Equals("http://openweathermap.org/img/w/03n.png"))
                     || (path.Equals("http://openweathermap.org/img/w/04d.png")) || (path.Equals("http://openweathermap.org/img/w/04n.png"))))
                {
                    path = ("cloud.png");
                }

                if ((path.Equals("http://openweathermap.org/img/w/09d.png")) || (path.Equals("http://openweathermap.org/img/w/09n.png")
                     || (path.Equals("http://openweathermap.org/img/w/10d.png")) || (path.Equals("http://openweathermap.org/img/w/10n.png"))))
                {
                    path = ("rain.png");
                }

                if ((path.Equals("http://openweathermap.org/img/w/50d.png"))||(path.Equals("http://openweathermap.org/img/w/50n.png")))
                {
                    path = ("haze.png");
                }

                if ((path.Equals("http://openweathermap.org/img/w/11d.png")) || (path.Equals("http://openweathermap.org/img/w/511n.png")))
                {
                    path = ("storm.png");
                }

                if ((path.Equals("http://openweathermap.org/img/w/13d.png")) || (path.Equals("http://openweathermap.org/img/w/13n.png")))
                {
                    path = ("snowflake.png");
                }

                ImageSource img = path;

                #endregion
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

