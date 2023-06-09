using programmeerija_plus.Model;
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
    public partial class Uus : ContentPage
    {
        public Uus()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            //UusList.ItemsSource = App.Andmebaas.HangiUksus();
            base.OnAppearing();
        }
        private async void LooPlaan(object sender, EventArgs e)
        {
            
            if (pealkiri_.Text == null || tegevused_.Text == null)
            {
                if (pealkiri_.Text == null)
                {
                    await DisplayAlert("Tähelepanu", "Te pole andmeid sisestanud. Kirjutage pealkiri, palun.", "Ok");
                }
                else if (tegevused_.Text == null)
                {
                    await DisplayAlert("Tähelepanu", "Te pole andmeid sisestanud. Kirjutage tegevused, palun.", "Ok");
                } 
            }
            else
            {
                tana.Date = DateTime.Now;
                var plaan = (Vaartused)BindingContext;
                App.andmebaas.LooUksus(plaan);
                await Navigation.PopAsync();
            }
            
            //await DisplayAlert("Test", App.andmebaas.LooUksus(plaan).ToString(), "ok");

  
        }
        private async void Sulge(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}