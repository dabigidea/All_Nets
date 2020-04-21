using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using All_Nets.Services;
using All_Nets.Views;

namespace All_Nets
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
