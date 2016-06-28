using Xamarin.Forms;

namespace Weather2
{
    public partial class App : Application
    {
        public App()
        {
           

            MainPage = new WeatherPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

