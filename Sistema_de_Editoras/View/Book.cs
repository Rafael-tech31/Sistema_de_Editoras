﻿using System;
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
                    
                }
                else if (opc == 21)
                {

                }
                else if (opc == 22)
                {

                }
                else if (opc == 23)
                {

                }
            } while (opc != 29);
        }
    }
}
