using System;
using Xamarin.Forms;

namespace Weather2
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {

            InitializeComponent();
            getWeatherbt.Clicked += GetWeatherbtn_Clicked;

            this.BindingContext = new Weather();

        }
        public async void GetWeatherbtn_Clicked(object sender, EventArgs e)
        {


            if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                Weather weather = await Core.GetWeather(zipCodeEntry.Text);
                this.BindingContext = weather;

            }
            else {
                Weather weather = await Core.GetWeather("60601,ES");
                this.BindingContext = weather;
            }

        }

    }
}

