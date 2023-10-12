using System;

namespace TriangulosService.Modelo
{
    public class Validacao
    {
        public Double primeiroLado;
        public Double segundoLado;
        public Double terceiroLado;
        public String mensagem;

        public String Validar(String ladoUm, String ladoDois, String ladoTres)
        {
            this.mensagem = "";

            try
            {
                if (ValidarEntradaExistente(ladoUm, ladoDois, ladoTres)) 
                    throw new Exception("ENTRADA :: Há valores inexistentes");

                this.primeiroLado = Double.Parse(ladoUm);
                this.segundoLado = Double.Parse(ladoDois);
                this.terceiroLado = Double.Parse(ladoTres);

                if (!ValidarPossivelTriangulo(this.primeiroLado, this.segundoLado, this.terceiroLado)) 
                    throw new Exception("ENTRADA :: Os valores não formam um triângulo");
            }
            catch (Exception ex)
            {
                this.mensagem = "ERRO " + ex.ToString();
            }

            return this.mensagem;
        }

        public Boolean ValidarEntradaExistente(String ladoUm, String ladoDois, String ladoTres)
        {
            if (ladoUm == null || ladoDois == null || ladoTres == null) return false;

            return true;
        }

        public Boolean ValidarPossivelTriangulo(Double ladoUm, Double ladoDois, Double ladoTres)
        {
            if (ladoUm + ladoDois > ladoTres
            || ladoUm + ladoTres > ladoDois
            || ladoDois + ladoTres > ladoUm) return false;

            return true;
        }
    }
}