﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Reflection;

namespace ByteBank_Portal.infraestrutura
{
    public class WebApplication
    {
        private readonly string[] _prefixos;

        public WebApplication(string[] prefixos)
        {
            if (prefixos == null)
                throw new ArgumentException(nameof(prefixos));
            _prefixos = prefixos;
        }

        public void Iniciar()
        {
            while (true)
            {
                ManipularRequisicao();
            }
        }

        public void ManipularRequisicao()
        {
            var httpListener = new HttpListener();

            foreach (var prefixo in _prefixos)
                httpListener.Prefixes.Add(prefixo);

            httpListener.Start();

            var contexto = httpListener.GetContext();
            var requisicao = contexto.Request;
            var resposta = contexto.Response;

            var path = requisicao.Url.AbsolutePath;

            var assembly = Assembly.GetExecutingAssembly();
            var nomeResource = Utilidades.ConverterPathParaNomeAssembly(path);

            var resourceStream = assembly.GetManifestResourceStream(nomeResource);

            if(resourceStream == null)
            {
                resposta.StatusCode = 404;
                resposta.OutputStream.Close();
            }
            else
            {
            var bytesResource = new byte[resourceStream.Length];

            resourceStream.Read(bytesResource, 0, (int)resourceStream.Length);

            resposta.ContentType = Utilidades.ObterTipoDeConteudo(path);
            resposta.StatusCode = 200;
            resposta.ContentLength64 = resourceStream.Length;

            resposta.OutputStream.Write(bytesResource, 0, bytesResource.Length);

            resposta.OutputStream.Close();

            }

            httpListener.Stop();
        }
    }
}
