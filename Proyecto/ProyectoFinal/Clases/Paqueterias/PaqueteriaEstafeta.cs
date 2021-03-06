﻿using System;
using System.Collections.Generic;

namespace ProyectoFinal
{
    public class PaqueteriaEstafeta : IPaqueteria
    {
        private PuentePaqueteriaTransporte puentePaqueteriaTransporte;
        private double dMargenUtilidad = 20;
        private Dictionary<int, string> DicTransportes = new Dictionary<int, string>()
        {
            { 1, "TREN" }
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
                throw new Exception($"ESTAFETA no ofrece el servicio por {_cTransporte}, te recomendamos cotizar en otra empresa.");
            }

            puentePaqueteriaTransporte = new TransporteBusiness().ObtenerTransporte(_cTransporte);

        }
    }
}
