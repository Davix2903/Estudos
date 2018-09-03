using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    [TestFixture]
    public class TesteDoAvaliador
    {
        [Test]
        public void Main()
        {
            //1º Parte: Cenário
            Usuario joao = new Usuario("Joao");
            Usuario henrique = new Usuario("Henrique");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(henrique, 400.0));
            leilao.Propoe(new Lance(maria, 250.0));

            //2º Parte: Ação
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            //3º Parte: Validação
            double menorEsperado = 250.0;
            double maiorEsperado = 400.0;

            Assert.AreEqual(maiorEsperado, leiloeiro.maiorLance);
            Assert.AreEqual(menorEsperado, leiloeiro.menorLance);
        }
    }
}
