using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    [TestFixture]
    public class AvaliadorTest
    {
        private Avaliador leiloeiro;
        private Usuario joao;
        private Usuario henrique;
        private Usuario maria;

        [SetUp]
        public void CriaAvaliador()
        {
            this.leiloeiro = new Avaliador();

            this.joao = new Usuario("Joao");
            this.henrique = new Usuario("Henrique");
            this.maria = new Usuario("Maria");
        }

        [Test]
        public void DeveEntenderLancesEmOrdemCrescenteComOutrosValores()
        {
            //1º Parte: Cenário


            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 1000.0));
            leilao.Propoe(new Lance(henrique, 2000.0));
            leilao.Propoe(new Lance(maria, 3000.0));

            //2º Parte: Ação
            CriaAvaliador();
            leiloeiro.Avalia(leilao);

            //3º Parte: Validação
            Assert.AreEqual(3000, leiloeiro.maiorLance);
            Assert.AreEqual(1000, leiloeiro.menorLance);
        }

        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
            .Lance(joao, 1000.0)
            .Constroi();

            CriaAvaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1000, leiloeiro.maiorLance, 0.0001);
            Assert.AreEqual(1000, leiloeiro.menorLance, 0.0001);
        }

        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 4 Novo")
            .Lance(joao, 400)
            .Lance(joao, 450)
            .Lance(maria, 425)
            .Lance(maria, 500.0)
            .Constroi();

            CriaAvaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.0001);
            Assert.AreEqual(300, maiores[1].Valor, 0.0001);
            Assert.AreEqual(200, maiores[2].Valor, 0.0001);
        }

    }
}