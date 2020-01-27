using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ConcreteAvion : ITransporte
    {
        private int iCostoEnvioxKm = 10;
        private int iVelocidadEntrega = 600;

        public string ObtenerCostoEnvio(double _MargenUtilidad, double _dDistancia)
        {
            double dCostoTotal = ObtenerCosto(_MargenUtilidad, _dDistancia);

            string cResultado = dCostoTotal + " pesos.";

            return cResultado;
        }

        public double obtenerTiempoEntregaEnDias(double _dDistancia)
        {
            double dDias = ((_dDistancia / iVelocidadEntrega) / 24);

            return dDias;
        }

        private double ObtenerCosto(double _MargenUtilidad, double _dDistancia)
        {
            double dCostoTotalEnvio = (iCostoEnvioxKm * _dDistancia * (1 + (_MargenUtilidad / 100)));

            return dCostoTotalEnvio;
        }
    }
}
