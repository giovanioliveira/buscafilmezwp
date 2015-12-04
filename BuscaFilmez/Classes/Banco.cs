using BuscaFilmes.Classes;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaFilmez.Classes
{
    public class Banco : DataContext
    {
        public static string DBConnectionString = "Data Source = 'isostore:filmez_db.sdf'";

        public Banco() : base(DBConnectionString)
        { }



        public Table<Filme> filmes
        {
            get { return this.GetTable<Filme>(); }
        }
    }
}
