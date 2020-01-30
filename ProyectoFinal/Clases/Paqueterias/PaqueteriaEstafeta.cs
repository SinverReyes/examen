using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class PaqueteriaEstafeta : IPaqueteria
    {
        private PuentePaqueteriaTransporte puentePaqueteriaTransporte;
        private double dMargenUtilidad = 20;
        private Dictionary<int, string> DicTransportes = new Dictionary<int, string>()
        {
            { 1, "Tren" },
            { 2, "Barco" },
            { 3, "Avion" }
        };

        public string obtenerCostoxPaqueteria(string transporte, double _dDistancia)
        {
            ValidarTransporte(transporte);

            string cMensaje = puentePaqueteriaTransporte.ObtenerCostoEnvio(dMargenUtilidad, _dDistancia);

            return cMensaje;
        }

        private void ValidarTransporte(string _cTransporte)
        {
            bool existe = DicTransportes.ContainsValue(_cTransporte);

            if (!existe)
            {
                throw new Exception($"DHL no ofrece el servicio por {_cTransporte}, te recomendamos cotizar en otra empreza");
            }

            puentePaqueteriaTransporte = new TransporteBusiness().obtenerTransporte(_cTransporte);

        }
    }
}
