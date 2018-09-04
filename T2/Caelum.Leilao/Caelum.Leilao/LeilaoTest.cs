using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    [TestFixture]
    public class LeilaoTest
    {
        [Test]
        public void DeveReceberUmLance()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");
            Assert.AreEqual(0, leilao.Lances.Count);

            var usuario = new Usuario("SteveJobs");
            leilao.Propoe(new Lance(usuario, 2000));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.00001);
        }

        [Test]
        public void DeveReceberVariosLances()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");
            leilao.Propoe(new Lance(new Usuario("Steve Jobs"), 2000));
            leilao.Propoe(new Lance(new Usuario("Steve Wozniak"), 3000));

            Assert.AreEqual(2, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.00001);
            Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.00001);
        }

        [Test]
        public void NaoDeveAceitarDoisLancesSeguidosDoMesmoUsuario()
        {
            Leilao leilao = new Leilao("Mac Book Pro 15");
            var steveJobs = new Usuario("Steve Jobs");

            leilao.Propoe(new Lance(steveJobs, 2000 ));
            leilao.Propoe(new Lance(steveJobs, 3000 ));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.00001);
        }

    }
}
