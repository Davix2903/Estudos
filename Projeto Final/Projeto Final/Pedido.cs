using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Final
{
    public class Pedido
    {
        List<ItensPedido> Itens;

        public ItensPedido ItensPedido
        {
            get => default(ItensPedido);
            set
            {
            }
        }
    }
}