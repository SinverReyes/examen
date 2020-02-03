using System;
using System.Collections.Generic;

namespace ProyectoFinal
{
    public class PaqueteriaBusiness
    {
        private PuentePaqueteria paqueteria;
        public Dictionary<int, string> DicPaqueterias = new Dictionary<int, string>()
        {
            { 1, "DHL" },
            { 2, "ESTAFETA" },
            { 3, "FEDEX" }
        };

        public PuentePaqueteria ElegirPaqueteria(string _cPaqueteria)
        {
            string cPaqueteriaMayuscula = _cPaqueteria.ToUpper();

            switch (cPaqueteriaMayuscula)
            {
                case "DHL": paqueteria = new PuentePaqueteria(new PaqueteriaDHL()); break;
                case "ESTAFETA": paqueteria = new PuentePaqueteria(new PaqueteriaEstafeta()); break;
                case "FEDEX": paqueteria = new PuentePaqueteria(new PaqueteriaFedex()); break;
                default: throw new Exception($"La Paquetería: {_cPaqueteria} no se encuentra registrada en nuestra red de distribución.");
            }

            return paqueteria;
        }

        public string ObtenerCostoMasBarato(double _dDistancia, string _cTransporte, string _cPaqueteria, double dCostoAnterior)
        {

            foreach (var dic in DicPaqueterias)
            {
                try
                {
                    if (dic.Value != _cPaqueteria.ToUpper())  
                    {
                        //se obtiene la paqueteria
                        var paqueteria = ElegirPaqueteria(dic.Value);

                        //se manda a calcular el costo del pedido por el transporte, pero antes pasa por la paqueteria para saber si cuenta con ese transporte 
                        double dCosto = paqueteria.ObtenerCostoPedido(_cTransporte, _dDistancia);

                        if (dCostoAnterior > dCosto)
                        {
                            return $"Si lo hubieses comprado en la paqueteria {dic.Value}, te hubiese salido {(dCostoAnterior - dCosto)} pesos menos.\n";
                        }
                    }
                }
                catch (Exception) { }
            }

            //En caso de que no se encuentre algun precio mas barato se regresa un mensaje vacio
            return null;
        }
    }
}
