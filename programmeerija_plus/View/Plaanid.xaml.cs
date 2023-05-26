using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programmeerija_plus.Model;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace programmeerija_plus.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Plaanid : ContentPage
    {
        public Plaanid()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            plaanList.ItemsSource = App.Andmebaas.HangiUksus();
            base.OnAppearing();
        }

        private async void plaanList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Vaartused selectedPlaan = (Vaartused)e.SelectedItem;
            Plaan plaan = new Plaan();
            plaan.BindingContext= selectedPlaan;
            await Navigation.PushAsync(plaan);
        }
    }
}