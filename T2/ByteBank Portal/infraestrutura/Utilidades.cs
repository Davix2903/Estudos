using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Portal.infraestrutura
{
    public static class Utilidades
    {

        public static string ConverterPathParaNomeAssembly(string path)
        {

            var prefixoAssembly = "ByteBank.Portal";
            var pathComPontos = path.Replace('/', '.');

            var nomeCompleto = $"{prefixoAssembly}.{pathComPontos}";

            return nomeCompleto;
        }

        public static string ObterTipoDeConteudo(string path)
        {
            if (path.EndsWith(".css"))
            {
                return "content"
            }
        }

    }
}
