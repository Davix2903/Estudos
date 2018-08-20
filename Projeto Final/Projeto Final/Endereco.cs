using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Projeto_Final
{
    public class Endereco
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Bairro { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(45)]
        public string Rua { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public string Numero { get; set; }

        [MinLength(3)]
        [MaxLength(15)]
        public string Complemento { get; set; }

        [MinLength(3)]
        [MaxLength(40)]
        public string Observacao { get; set; }
    }
}