using BuscaFilmez.Classes;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaFilmes.Classes
{
     [Table(Name = "filmes")]
    public class Filme
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }
         [Column(CanBeNull = false)]
        public String nome { get; set; }
         [Column(CanBeNull = false)]
        public int ano { get; set; }
         [Column(CanBeNull = false)]
        public String poster { get; set; }
         [Column(CanBeNull = false)]

        public String imdbID { get; set; }

        private static Banco GetDataBase()
        {
            Banco db = new Banco();
            if (!db.DatabaseExists())
                db.CreateDatabase();
            return db;
        }

        public static void Create(Filme filme)
        {
            Banco db = GetDataBase();
            db.filmes.InsertOnSubmit(filme);
            db.SubmitChanges();

        }

        public static List<Filme> Get()
        {
            Banco db = GetDataBase();
            var query = from filmes in db.filmes select filmes;
            List<Filme> filme_lista = new List<Filme>(query.AsEnumerable());
            return filme_lista;
        }

       
      



    }
}
