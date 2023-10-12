using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TriangulosService.Modelo;

namespace TriangulosService
{
    public class Service1 : IService1
    {

        public String CalcularTipoTriangulo(String primeiroLado, String segundoLado, String terceiroLado)
        {
            Controle controle = new Controle();
            return controle.Calcular(primeiroLado, segundoLado, terceiroLado);
        }
    }
}
