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
        public string Title { get; set; }
        public string Tegevused { get; set; }
        public string Fail { get; set; }
        public DateTime Alates { get; set; }
        public DateTime Kuni { get; set; }
    }
}
