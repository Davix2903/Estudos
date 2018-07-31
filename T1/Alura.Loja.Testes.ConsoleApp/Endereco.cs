namespace Alura.Loja.Testes.ConsoleApp
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Numero { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Cliente Cliente { get; set; }
    }
}