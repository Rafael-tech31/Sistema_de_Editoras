using Sistema_de_Editoras.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Editoras.Controller
{
    public class BookController
    {
        private List<BookModel> _listaBook = new List<BookModel>();

        public void Adicionar(BookModel valor)
        {
            _listaBook.Add(valor);
        }
        public void excluir(BookModel valor)
        {

        }
        public void atualizar(BookModel valor)
        {

        }
        public BookModel search(Int32 CodLivro)
        {
            BookModel valor = null;

            foreach (var item in _listaBook)
            {
                if (item.CodLivro == CodLivro)
                {
                    valor = item;
                }
            }
            return valor;
        }
    }
