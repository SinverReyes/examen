using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public interface ITransporte
    {
        string ObtenerCostoEnvio(double _MargenUtilidad, double _dDistancia);

        double obtenerTiempoEntregaEnDias(double _dDistancia);
    }
}
