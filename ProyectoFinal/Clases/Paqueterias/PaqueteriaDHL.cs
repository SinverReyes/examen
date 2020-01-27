using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class PaqueteriaDHL : IPaqueteria
    {
        private PuentePaqueteriaTransporte puentePaqueteriaTransporte;
        private double dMargenUtilidad = 40;

        public string obtenerCostoxPaqueteria(string transporte, double _dDistancia)
        {
            string cMensaje;

            obtenerTransporte(transporte);

            cMensaje = puentePaqueteriaTransporte.ObtenerCostoEnvio(dMargenUtilidad, _dDistancia);

            return cMensaje;
        }

        public double ObtenerTiempoEntregaEnDias(string transporte, double _dDistancia)
        {
            double dias;

            obtenerTransporte(transporte);

            dias = puentePaqueteriaTransporte.obtenerTiempoEntregaEnDias(_dDistancia);

            return dias;
        }

        public void obtenerTransporte(string _cTransporteMayuscula)
        {
            string cTransporteMayuscula = _cTransporteMayuscula.ToUpper();

            switch (cTransporteMayuscula)
            {
                case "BARCO":
                    puentePaqueteriaTransporte = new PuentePaqueteriaTransporte(new ConcreteBarco());
                    break;
                case "TREN":
                    puentePaqueteriaTransporte = new PuentePaqueteriaTransporte(new ConcreteTren());
                    break;
                case "AVION":
                    puentePaqueteriaTransporte = new PuentePaqueteriaTransporte(new ConcreteAvion());
                    break;
                default:
                    throw new Exception("La paqueteria no cuenta con envios por " + _cTransporteMayuscula);
            }
        }
    }
}
