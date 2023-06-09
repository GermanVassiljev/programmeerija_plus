using programmeerija_plus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace programmeerija_plus.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        List<string> nuppid = new List<string> {"Plaanid", "Uus","Sätted" };
        StackLayout layout = new StackLayout();
        List<Button> nuppid_ = new List<Button>();
        Label Tekst;
        public Menu()
        {
            InitializeComponent();
            layout.BackgroundColor = Color.SkyBlue;

            Tekst = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.MidnightBlue,
                TextColor = Color.White,
                FontSize = 26,
                Text = "Programmeerija +",
                WidthRequest = 400,
                Padding= 5,
                
            };
            layout.Children.Add(Tekst);
            for (int i = 0; i < nuppid.Count; i++)
            {
                Button e = new Button
                {
                    HorizontalOptions = LayoutOptions.Center,
                    BackgroundColor = Color.MidnightBlue,
                    TextColor = Color.White,
                    FontSize = 16,
                    Text = nuppid[i],
                    CharacterSpacing = 3,
                    WidthRequest = 500,
                    Margin = 10,
                    CornerRadius = 10,
                };
                nuppid_.Add(e);
                e.Clicked += E_Clicked;
                layout.Children.Add(e);
            }
            Content= layout;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //App.Teema = "Klassikaline";
            Teemad();

        }


        private async void E_Clicked(object sender, EventArgs e)
        {
            var nupp = (Button)sender;
            if (nupp.Text == nuppid[0])
            {
                await Navigation.PushAsync(new NavigationPage(new Plaanid()));
            }
            else if (nupp.Text == nuppid[1])
            {
                Vaartused vaart = new Vaartused();
                Uus uus = new Uus();
                uus.BindingContext = vaart;
                await Navigation.PushAsync(uus);
            }
            else if (nupp.Text == nuppid[2])
            { 
                await Navigation.PushAsync(new NavigationPage(new Satted()));
            }
        }
        private void Teemad()
        {
            if (App.Teema == "Klassikaline")
            {
                layout.BackgroundColor = Color.SkyBlue;

                foreach (var nuppid in nuppid_)
                {
                    nuppid.BackgroundColor = Color.MidnightBlue;
                    nuppid.TextColor = Color.White;
                }

                Tekst.BackgroundColor = Color.MidnightBlue;
                Tekst.TextColor = Color.White;
            }
            else if (App.Teema == "Tume")
            {
                layout.BackgroundColor = Color.DarkBlue;

                foreach (var nuppid in nuppid_)
                {
                    nuppid.BackgroundColor = Color.MidnightBlue;
                    nuppid.TextColor = Color.White;
                }

                Tekst.BackgroundColor = Color.MidnightBlue;
                Tekst.TextColor = Color.White;
            }
            else
            {
                layout.BackgroundColor = Color.LightBlue;

                foreach (var nuppid in nuppid_)
                {
                    nuppid.BackgroundColor = Color.SkyBlue;
                    nuppid.TextColor = Color.Black;
                }

                Tekst.BackgroundColor = Color.SkyBlue;
                Tekst.TextColor = Color.Black;
            }
        }
    }
}