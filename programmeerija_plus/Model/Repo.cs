using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace programmeerija_plus.Model
{
    public class Repo
    {
        SQLiteConnection andmebaas;
        public Repo(string databasePath)
        {
            andmebaas = new SQLiteConnection(databasePath);
            andmebaas.CreateTable<Vaartused>();
        }
        public IEnumerable<Vaartused> HangiUksus()
        {
            return andmebaas.Table<Vaartused>().ToList();
        }
        public Vaartused HangiUksus(int id)
        {
            return andmebaas.Get<Vaartused>(id);
        }
        public int KustutaUksus(int id)
        {
            return andmebaas.Delete<Vaartused>(id);
        }
        public int SalvestaUksus(Vaartused item)
        {
            if (item.Id != 0)
            {
                andmebaas.Update(item);
                return item.Id;
            }
            else
            {
                return andmebaas.Insert(item);
            }
        }
    }
}
