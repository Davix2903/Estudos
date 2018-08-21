using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Projeto_Final
{
    public class Funcionario : Usuarios
    {
        [Required]
        [MinLength(5)]
        [MaxLength(40)]
        public string NomeCompleto { get; set; }

        [Required]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        [MinLength(9)]
        [MaxLength(25)]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(25)]
        public String Senha { get; set; }
    }
}