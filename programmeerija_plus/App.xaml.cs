using programmeerija_plus;
using programmeerija_plus.Model;
using programmeerija_plus.View;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace programmeerija_plus
{
    public partial class App : Application
    {
        public const string ANDMEBAAS_NIMI = "vaartused.db";
        public static Repo andmebaas;
        public static Repo Andmebaas
        {
            get
            {
                if (andmebaas == null)
                {
                    andmebaas = new Repo(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ANDMEBAAS_NIMI));
                }
                return andmebaas;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.Menu());
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
