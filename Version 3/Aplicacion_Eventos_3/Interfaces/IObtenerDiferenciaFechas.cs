using System;

namespace Aplicacion_Eventos_3.Interfaces
{
    public interface IObtenerDiferenciaFechas
    {
        int ObtenerDiferenciaDias(DateTime dtFechaBase, DateTime dtFechaComparar);
        int ObtenerDiferenciaMes(DateTime dtFechaBase, DateTime dtFechaComparar);
        int ObtenerDiferenciaHoras(DateTime dtFechaBase, DateTime dtFechaComparar);
        int ObtenerDiferenciaMinutos(DateTime dtFechaBase, DateTime dtFechaComparar);
    }
}
