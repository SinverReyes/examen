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

        public string ObtenerCostoEnvio(double _MargenUtilidad, double _dDistancia)
        {
            return "Barco: The resultado de enviar el paquete es de $100 pesos.\n";
        }

        public double obtenerTiempoEntregaEnDias(double _dDistancia)
        {
            throw new NotImplementedException();
        }
    }
}
