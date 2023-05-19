using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace programmeerija_plus.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        List<string> nuppid = new List<string> {"Plaanid", "Uus","Sätted" };
        public Menu()
        {
            InitializeComponent();
            StackLayout layout = new StackLayout();
            layout.BackgroundColor = Color.SkyBlue;

            Label Tekst = new Label
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
                e.Clicked += E_Clicked;
                layout.Children.Add(e);
            }
            Content= layout;
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
                await Navigation.PushAsync(new NavigationPage(new Satted()));
            }
            else if (nupp.Text == nuppid[2])
            {
                await Navigation.PushAsync(new NavigationPage(new Uus()));
            }
        }
    }
}