using System;
using System.Collections.Generic;

namespace ProyectoFinal
{
    public class PaqueteriaDHL : IPaqueteria
    {
        private PuentePaqueteriaTransporte puentePaqueteriaTransporte;
        private double dMargenUtilidad = 40;
        private Dictionary<int, string> DicTransportes = new Dictionary<int, string>()
        {
            { 1, "AVION" },
            { 2, "BARCO" }
        };

        public double ObtenerCostoPedido(string transporte, double _dDistancia)
        {
            ValidarTransporte(transporte);

            double dCosto = puentePaqueteriaTransporte.ObtenerCostoEnvio(dMargenUtilidad, _dDistancia);

            return dCosto;
        }

        public double ObtenerTiempoEntrega(double _dDistancia)
        {
            double dHoras = puentePaqueteriaTransporte.ObtenerTiempoEntrega(_dDistancia);

            return dHoras;
        }

        private void ValidarTransporte(string _cTransporte)
        {
            bool existe = DicTransportes.ContainsValue(_cTransporte.ToUpper());

            if (!existe)
            {
                throw new Exception($"DHL no ofrece el servicio por {_cTransporte}, te recomendamos cotizar en otra empresa.");
            }

            puentePaqueteriaTransporte = new TransporteBusiness().ObtenerTransporte(_cTransporte);
        }
    }
}
