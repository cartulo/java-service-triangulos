using System;

namespace TriangulosService.Modelo
{
    public class Controle
    {
        public String Calcular(String ladoUm, String ladoDois, String ladoTres)
        {
            String resposta;
            Validacao validacao = new Validacao();

            validacao.Validar(ladoUm, ladoDois, ladoTres);

            if (validacao.mensagem.Equals(""))
            {
                Triangulos triangulos = new Triangulos();
                resposta = triangulos.CalcularTriangulo(validacao.primeiroLado, validacao.segundoLado, validacao.terceiroLado);
            }
            else
            {
                resposta = validacao.mensagem;
            }

            return resposta;
        }
    }
}