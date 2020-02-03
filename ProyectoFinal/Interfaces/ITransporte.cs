using System;

namespace ProyectoFinal
{
    public interface ITransporte
    {
        double ObtenerCostoEnvio(double _MargenUtilidad, double _dDistancia);

        double ObtenerTiempoEntrega(double _dDistancia);
    }
}
