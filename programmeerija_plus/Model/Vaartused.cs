using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace programmeerija_plus.Model
{
    [Table("Too")]
    public class Vaartused
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public string nimi { get; set; }
        public string tegevused { get; set; }
        public string fail { get; set; }
        public DateTime alates { get; set; }
        public DateTime kuni { get; set; }
    }
}
