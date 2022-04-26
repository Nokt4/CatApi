using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CatApi.Services;
using CatApi.Views;

namespace CatApi
{
    public partial class App : Application
    {
        public static CatManager CatManager { get; set; }
        public App()
        {
            InitializeComponent();
            CatManager = new CatManager(new RestService());
            MainPage = new NavigationPage(new CatListPage());
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
