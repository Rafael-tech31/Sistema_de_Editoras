using Sistema_de_Editoras.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Editoras.Controller
{
    public class PublisheController
    {
        private List<PublisherModel> _listaPublishers = new List<PublisherModel>();

        public void Adicionar(PublisherModel valor)
        {
            _listaPublishers.Add(valor);
        }
        public void excluir(PublisherModel valor)
        {

        }
        public void atualizar(PublisherModel valor)
        {

        }
        public PublisherModel search(Int32 codigo)
        {
            PublisherModel valor = null;

            foreach(var item in _listaPublishers)
            {
                if(item.codigo == codigo)
                {
                    valor = item;
                }
            }
            return valor;
        }
    }
}
