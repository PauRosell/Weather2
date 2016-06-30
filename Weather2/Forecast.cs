using System;

using Xamarin.Forms;

namespace Weather2
{
    public class Forecast : ContentPage
    {
        public Forecast()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


