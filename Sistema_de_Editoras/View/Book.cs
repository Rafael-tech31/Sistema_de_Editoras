using Sistema_de_Editoras.Controller;
using Sistema_de_Editoras.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Editoras.View
{
    class Book : MenuAbstract
    {
        public override void Criar()
        {
            BookController books = new BookController();
            int opc = 0;
            do
            {
                Console.WriteLine("=====BOOKS=====");
                Console.WriteLine("20. Insert \n");
                Console.WriteLine("21. Alter \n");
                Console.WriteLine("22. Delete \n");
                Console.WriteLine("23. search \n");
                Console.WriteLine("29. exit \n");
                Console.WriteLine("Digire a opção: ");
                opc = Int32.Parse(Console.ReadLine());

                if (opc == 20)
                {
                    BookModel bookk = new BookModel();
                    bookk.CodLivro = (Int32.Parse(Console.ReadLine()));
                    bookk.nameBook = (Console.ReadLine());
                    bookk.livanoPublicação = (Int32.Parse(Console.ReadLine()));
                    bookk.isbnBook = (decimal.Parse(Console.ReadLine()));

                    books.Adicionar(bookk);

                    Console.WriteLine("Livro Adicionado com sucesso!");
                }
                else if (opc == 21)
                {

                }
                else if (opc == 22)
                {

                }
                else if (opc == 23)
                {
                    Int32 CodLivro = Int32.Parse(Console.ReadLine());

                    BookModel searchBook = new BookModel();
                    searchBook = books.search(CodLivro);

                    if (searchBook == null)
                    {
                        Console.WriteLine("Codigo não localizado!");
                    }
                    else
                    {
                        Console.WriteLine(searchBook.nameBook.ToString());
                    }
                }
            } while (opc != 29);
        }
    }
}
