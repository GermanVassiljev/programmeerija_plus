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
            base.OnAppearing();
        }
        private async void LooPlaan(object sender, EventArgs e)
        {
            var plaan = (Vaartused)BindingContext;

            App.andmebaas.LooUksus(plaan);

            await Navigation.PopAsync();
        }
        private async void Sulge(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}