using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMountComputer.Modelos
{
    [Table("Processador")]
    public class Processador
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string marca { get; set; }
        public string linha { get; set; }
        public string modelo { get; set; }
        public double preco { get; set; }

    }
}
