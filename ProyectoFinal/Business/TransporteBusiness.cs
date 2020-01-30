using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class TransporteBusiness
    {
        private PuentePaqueteriaTransporte puenteTransporte;

        public PuentePaqueteriaTransporte obtenerTransporte(string _cTransporte)
        {
            string cTransporteMayuscula = _cTransporte.ToUpper();

            switch (cTransporteMayuscula)
            {
                case "BARCO":
                    puenteTransporte = new PuentePaqueteriaTransporte(new ConcreteBarco());
                    break;
                case "TREN":
                    puenteTransporte = new PuentePaqueteriaTransporte(new ConcreteTren());
                    break;
                case "AVION":
                    puenteTransporte = new PuentePaqueteriaTransporte(new ConcreteAvion());
                    break;
                default:
                    throw new Exception("La paqueteria no cuenta con envios por " + _cTransporte);
            }

            return puenteTransporte;
        }

        public double obtenerTiempoEntregaxTransporte(string _cTransporte, double _dDistancia)
        {
            puenteTransporte = obtenerTransporte(_cTransporte);

            double dTiempoEntrega = puenteTransporte.obtenerTiempoEntrega(_dDistancia);

            return dTiempoEntrega;
        }
    }
}
