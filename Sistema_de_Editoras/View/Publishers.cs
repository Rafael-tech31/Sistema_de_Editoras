using Sistema_de_Editoras.Controller;
using Sistema_de_Editoras.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Editoras.View
{
    class Publishers : MenuAbstract
    {
        public override void Criar()
        {
            PublisheController editoras = new PublisheController();
            int opc = 0;
            do
            {
                Console.WriteLine("\n\n=====PUBLISHERS===== \n");
                Console.WriteLine("10. Insert \n");
                Console.WriteLine("11. Alter \n");
                Console.WriteLine("12. Delete \n");
                Console.WriteLine("13. search \n");
                Console.WriteLine("19. exit \n");
                Console.WriteLine("Digire a opção: ");
                opc = Int32.Parse(Console.ReadLine());

                if (opc == 10)
                {
                    PublisherModel editora = new PublisherModel();
                    editora.codigo = (Int32.Parse(Console.ReadLine()));
                    editora.nome = (Console.ReadLine());
                    editora.sigla = (Console.ReadLine());

                    editoras.Adicionar(editora);

                    Console.WriteLine("Editora adicionado com sucesso!");
                }
                else if (opc == 11)
                {
                    
                }
                else if (opc == 12)
                {

                }
                else if (opc == 13)
                {
                    Int32 codigo = Int32.Parse(Console.ReadLine());

                    PublisherModel searchEdit = new PublisherModel();
                    searchEdit = editoras.search(codigo);

                    if(searchEdit == null)
                    {
                        Console.WriteLine("Codigo não localizado!");
                    }
                    else
                    {
                        Console.WriteLine(searchEdit.nome.ToString());
                    }
                }
            } while (opc != 19);
        }
    }
}
