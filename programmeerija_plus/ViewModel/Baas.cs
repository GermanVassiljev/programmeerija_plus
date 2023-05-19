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

namespace programmeerija_plus.ViewModel
{
    public partial class Baas
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "vaartused.db");
        SQLiteConnection connection = new SQLiteConnection(path);
        
    }
}
