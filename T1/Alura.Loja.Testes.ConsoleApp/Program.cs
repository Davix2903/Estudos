using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fulano = new Cliente();
            fulano.Nome = "Fulaninho de Tal";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = "100",
                Rua = "Rua Mexicana",
                Bairro = "Ruínas",
                Cidade = "São Paulo"
            };

            using (var contexto = new LojaContext())
            {

            }

            //static void Main(string[] args)
            //{
            //    //var promocaoDePascoa = new Promocao();
            //    //promocaoDePascoa.DataInicio = DateTime.Now;
            //    //promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);
            //    ////promocaoDePascoa.Produtos.Add(new Produto());

            //    ////using (var contexto = new LojaContext())
            //    ////{
            //    ////    //contexto.SaveChanges();
            //    ////}
            //}

        }
    }
}
