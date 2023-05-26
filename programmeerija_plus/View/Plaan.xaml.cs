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
    public partial class Plaan : ContentPage
    {
        public Plaan()
        {
            InitializeComponent();
        }
        
        private void SalvestaPlaan(object sender, EventArgs e)
        {
            var plaan = (Vaartused)BindingContext;
            if (!String.IsNullOrEmpty(plaan.Title))
            {
                App.Andmebaas.SalvestaUksus(plaan);
            }
            this.Navigation.PopAsync();
        }
        private void KustutaPlaan(object sender, EventArgs e)
        {
            var plaan = (Vaartused)BindingContext;
            App.Andmebaas.KustutaUksus(plaan.Id);
            this.Navigation.PopAsync();
        }
        private void Sulge(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}