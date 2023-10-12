using System;

namespace TriangulosService.Modelo
{
    public class Triangulos
    {
        private String resultado;

        public String CalcularTriangulo(Double ladoUm, Double ladoDois, Double ladoTres)
        {
            this.resultado = "";

            if ((ladoUm + ladoDois) / 2 == ladoTres)
            {
                this.resultado = "O triângulo é Equilátero";
            }

            else if ((ladoUm + ladoDois) / 2 == ladoUm 
                || (ladoDois + ladoTres) / 2 == ladoDois 
                || (ladoUm + ladoTres) / 2 == ladoUm)
            {
                this.resultado = "O triângulo é Isósceles";
            }

            else
            {
                this.resultado = "O triângulo é Escaleno";
            }

            return resultado;
        }
}
}