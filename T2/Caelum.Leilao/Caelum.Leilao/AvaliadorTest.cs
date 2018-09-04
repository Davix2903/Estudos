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

        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Usuario joao = new Usuario("Joao");
            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 1000.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1000, leiloeiro.maiorLance, 0.0001);
            Assert.AreEqual(1000, leiloeiro.menorLance, 0.0001);
        }

        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Usuario joao = new Usuario("Joao");
            Usuario maria = new Usuario("Maria");
            Leilao leilao = new Leilao("Playstation 4 Novo");

            leilao.Propoe(new Lance(joao, 400));
            leilao.Propoe(new Lance(joao, 450));
            leilao.Propoe(new Lance(maria, 425));
            leilao.Propoe(new Lance(maria, 500.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.0001);
            Assert.AreEqual(300, maiores[1].Valor, 0.0001);
            Assert.AreEqual(200, maiores[2].Valor, 0.0001);
        }

    }
}