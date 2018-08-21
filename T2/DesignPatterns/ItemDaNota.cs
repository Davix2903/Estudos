namespace DesignPatterns
{
    public class ItemDaNota
    {
        public string Nome { get; private set; }

        public double Valor { get; private set; }

        public ItemDaNota(string Nome, double Valor)
        {
            this.Nome = Nome;
            this.Valor = Valor;
        }
    }
}