using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace Projeto_Final
{
    public class ItensPedido
    {
        [Required]
        public string SaborDaPizza01 { get; set; }

        public string SaborDaPizza02 { get; set; }

        public string SaborDaPizza03 { get; set; }

        public string Refrigerante { get; set; }

        public string Broto { get; set; }
    }
}