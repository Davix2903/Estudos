using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(String[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
                .ParaEmpresa("Pizzaria Rio Claro")
                .ComCnpj("123")
                .ComItem(new ItemDaNota("item 1", 100.0))
                .ComItem(new ItemDaNota("item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("Uma Obs qualquer");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new EnviadorDeSms());
            criador.AdicionaAcao(new NotaFiscalDAO());

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();
        }
    }
}
