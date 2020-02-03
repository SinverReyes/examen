using System;

namespace ProyectoFinal
{
    public class FechasService
    {
        private DiferenciaFechasBusiness business;

        public FechasService(DiferenciaFechasBusiness _business)
        {
            business = _business;
        }

        public string ObtenerDiferenciaFechas(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            return business.obtenerDiferenciaFechas(_dtFechaEntrega, _dtFechaActual);
        }
    }
}
