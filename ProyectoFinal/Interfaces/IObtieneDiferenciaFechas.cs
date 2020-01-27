using System;

namespace ProyectoFinal
{
    public interface IObtieneDiferenciaFechas
    {
        IObtieneDiferenciaFechas NextNivel(IObtieneDiferenciaFechas Handler);

        string ObtenerDiferenciaFechas();
        //string ObtenerDiferenciaFechas(DateTime FechaBase, DateTime FechaComparar);
    }
}
