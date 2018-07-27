using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();

                ExibeEntries(contexto.ChangeTracker.Entries());

                //var novoProduto = new Produto()
                //{
                //    Nome = "Desinfetante",
                //    Categoria = "Limpeza",
                //    Preco = 2.99
                //};
                //contexto.Produtos.Add(novoProduto);

                var p1 = produtos.First();
                contexto.Produtos.Remove(p1);

                ExibeEntries(contexto.ChangeTracker.Entries());

                //contexto.SaveChanges();

                //ExibeEntries(contexto.ChangeTracker.Entries());
            }
        }



        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            foreach (var e in entries)
            {
                Console.WriteLine("==============");
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }

        }
    }
}

