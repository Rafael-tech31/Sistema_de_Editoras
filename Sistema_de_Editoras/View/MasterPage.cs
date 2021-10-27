using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Editoras.View
{
    public class MasterPage : MenuAbstract
    {
        public override void Criar()
        {
            int opc = 0;
            do
            {
                Console.WriteLine("=====SISTEMA DE EDITORAS===== \n");
                Console.WriteLine("1. Publishers \n");
                Console.WriteLine("2. Book \n");
                Console.WriteLine("3. Book_Authors \n");
                Console.WriteLine("4. Authors \n");
                Console.WriteLine("9. sair \n");
                Console.WriteLine("Digire a opção: ");
                opc = Int32.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    Publishers editora = new Publishers();
                    editora.Criar();
                }
                else if (opc == 2)
                {
                    Book livro = new Book();
                    livro.Criar();
                }
                else if (opc == 3)
                {
                    Book_authors autoreslivros = new Book_authors();
                    autoreslivros.Criar();
                }
                else if (opc == 4)
                {
                    Authors autor = new Authors();
                    autor.Criar();
                }
            } while (opc != 9);
            //Por contem um Sleep não é necessario apertar nada para fechar o menu,
            //Pois a um um tempo determinado para que seja fechado 
            Console.WriteLine("Obrigado por usar o nosso sistema de editoras!");
            Console.WriteLine("Volte sempre!");
            Thread.Sleep(2500);
        }
    }
}
