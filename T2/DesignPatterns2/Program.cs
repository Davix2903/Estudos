using DesignPatterns2.Cap01;
using DesignPatterns2.Cap02;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>()
            {
                //notas.Pega("do"),
                //notas.Pega("do"),
                //notas.Pega("re"),
                //notas.Pega("do"),
                //notas.Pega("fa"),
                //notas.Pega("mi"),
                ////...
                //notas.Pega("do"),
                //notas.Pega("do"),
                //notas.Pega("re"),
                //notas.Pega("do"),
                //notas.Pega("sol"),
                //notas.Pega("fa"),
                //notas.Pega("fa"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("re"),
            notas.Pega("re"),

            notas.Pega("do"),
            notas.Pega("sol"),
            notas.Pega("fa"),
            notas.Pega("mi"),
            notas.Pega("mi"),
            notas.Pega("mi"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa")
            };

            Piano piano = new Piano();
            piano.Toca(musica);
        }
    }
}
