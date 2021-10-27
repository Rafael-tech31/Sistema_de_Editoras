using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Editoras.View
{
    class Book_authors : MenuAbstract
    {
        public override void Criar()
        {
            int opc = 0;
            do
            {
                Console.WriteLine("=====AUTHORS_BOOK=====");
                Console.WriteLine("30. Insert \n");
                Console.WriteLine("31. Alter \n");
                Console.WriteLine("32. Delete \n");
                Console.WriteLine("33. search \n");
                Console.WriteLine("39. exit \n");
                Console.WriteLine("Digire a opção: ");
                opc = Int32.Parse(Console.ReadLine());

                if (opc == 30)
                {

                }
                else if (opc == 31)
                {

                }
                else if (opc == 32)
                {

                }
                else if (opc == 33)
                {

                }
            } while (opc != 39);
        }
    }
}
