using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Projeto_Final
{
    public class Compra
    {
        [Required]
        public FormaDePagamento FormaDePagamento { get; set; }
    }
}