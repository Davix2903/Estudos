namespace Alura.Loja.Testes.ConsoleApp
{
    internal class Compra
    {
        public int id { get; set; }
        public int Quantidade { get; internal set; }
        public double PrecoTotal { get; internal set; }
        public Produto Produto { get; internal set; }
        public int ProdutoId { get; set; }
    }
}