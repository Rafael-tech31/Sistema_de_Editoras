using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Editoras.Model
{
    public class BookModel 
    {
        public int CodLivro { get; set; }
        public string nameBook { get; set; }
        public int livanoPublicação { get; set; }
        public decimal isbnBook { get; set; }
    }
}
