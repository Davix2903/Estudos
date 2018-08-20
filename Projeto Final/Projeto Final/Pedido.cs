using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Projeto_Final
{
    public class Pedido
    {
        [Required]
        public List<ItensPedido> Itens { get; set; }

        public ItensPedido ItensPedido { get; set; }
    }
}