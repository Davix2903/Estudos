using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);
            promocaoDePascoa.Produtos.Add(new Produto());

            using (var contexto = new LojaContext())
            {
                contexto.SaveChanges();
            }
        }

    }
}
