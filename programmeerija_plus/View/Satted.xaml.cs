using programmeerija_plus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace programmeerija_plus.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Satted : ContentPage
    {
        List<string> nuppid = new List<string> { "Teema", "Teavitus" };
        StackLayout layout = new StackLayout();
        List<Button> nuppid_ = new List<Button>();
        Label Tekst;
        public Satted()
        {
            InitializeComponent();
            layout.BackgroundColor = Color.SkyBlue;
            Tekst = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.MidnightBlue,
                TextColor = Color.White,
                FontSize = 26,
                Text = "Sätted",
                WidthRequest = 400,
                Padding = 5,

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
                e.Clicked += E_Clicked;
                nuppid_.Add(e);
                layout.Children.Add(e);
            }
            Content = layout;


   
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //App.Teema = new Vaartused { Teema = "Tume" };
            Teema();

        }

        public bool Teavitus = true;
        private async void E_Clicked(object sender, EventArgs e)
        {
            var nupp = (Button)sender;
            if (nupp.Text == nuppid[0])
            {
                string teemad = await DisplayActionSheet("Teema", "sulge", "Valige teema", "Klassikaline", "Tume", "Valgus");
                App.Teema = teemad;
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
            else if (nupp.Text == nuppid[1])
            {
                Teavitus = await DisplayAlert("Teavitus", "Kas soovite teateid saada?", "Yah", "Ei");
            }
        }

        private void Teema()
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