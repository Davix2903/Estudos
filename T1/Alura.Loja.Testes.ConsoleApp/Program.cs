namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //compra de 6 pães franceses
            var PaoFrances = new Produto();
            PaoFrances.Nome = "Pão Francês";
            PaoFrances.PrecoUnitario = 0.40;
            PaoFrances.Categoria = "Padaria";

            var compra = new Compra();
            compra.Quantidade = 6;
            compra.PrecoTotal = PaoFrances.PrecoUnitario * compra.Quantidade;
            compra.Produto = PaoFrances;

            using(var contexto = new LojaContext())
        {
              

                contexto.Compras.Add(compra);

                contexto.SaveChanges();
            }
        }        
    }
}

