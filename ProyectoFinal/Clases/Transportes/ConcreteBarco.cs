using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ConcreteBarco : ITransporte
    {
        private int iCostoEnvioxKm = 1;
        private int iVelocidadEntrega = 46;

        public string ObtenerCostoEnvio(double _MargenUtilidad, double _dDistancia)
        {
            double dCostoTotal = (iCostoEnvioxKm * _dDistancia * (1 + (_MargenUtilidad / 100)));

            string cResultado = dCostoTotal + " pesos";

            return cResultado;
        }

        public double obtenerTiempoEntrega(double _dDistancia)
        {
            double dHoras = (_dDistancia / iVelocidadEntrega);

            return dHoras;
        }
    }
}
