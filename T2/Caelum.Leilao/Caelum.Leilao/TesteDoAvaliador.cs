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
        public void DeveEntenderLancesEmOrdemCrescenteComOutrosValores()
        {
            //1º Parte: Cenário
            Usuario joao = new Usuario("Joao");
            Usuario henrique = new Usuario("Henrique");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 1000.0));
            leilao.Propoe(new Lance(henrique, 2000.0));
            leilao.Propoe(new Lance(maria, 3000.0));

            //2º Parte: Ação
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            //3º Parte: Validação
            Assert.AreEqual(3000, leiloeiro.maiorLance);
            Assert.AreEqual(1000, leiloeiro.menorLance);
        }
    }
}
