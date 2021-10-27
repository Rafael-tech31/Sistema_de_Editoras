using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Editoras.View
{
    class Authors : MenuAbstract
    {
        public override void Criar()
        {
            int opc = 0;
            do
            {
                Console.WriteLine("=====AUTHORS=====");
                Console.WriteLine("40. Insert \n");
                Console.WriteLine("41. Alter \n");
                Console.WriteLine("42. Delete \n");
                Console.WriteLine("43. search \n");
                Console.WriteLine("49. exit \n");
                Console.WriteLine("Digire a opção: ");
                opc = Int32.Parse(Console.ReadLine());

                if (opc == 40)
                {

                }
                else if (opc == 41)
                {

                }
                else if (opc == 42)
                {

                }
                else if (opc == 43)
                {

                }
            } while (opc != 49);
        }
    }
}

