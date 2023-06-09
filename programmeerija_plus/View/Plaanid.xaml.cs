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
using static System.Net.Mime.MediaTypeNames;

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
            //Teemad();
        }
        
        private async void plaanList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Vaartused selectedPlaan = (Vaartused)e.SelectedItem;
            Plaan plaan = new Plaan();
            plaan.BindingContext = selectedPlaan;
            await Navigation.PushAsync(plaan);
        }

        /*private void Teemad()
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
        }*/
    }
}