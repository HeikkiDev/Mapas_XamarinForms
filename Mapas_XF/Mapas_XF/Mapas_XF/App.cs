using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Mapas_XF
{
    public class App : Application
    {
        public MeetingPoint meetingPoint;
        public ObservableCollection<MeetingPoint> listaPuntos;

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new InitialPage());   // Mi página de inicio

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
