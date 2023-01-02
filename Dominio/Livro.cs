using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public class Livro
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public DateTime AnoPublicacao { get; set; }
        
    }
}
