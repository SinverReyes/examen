using System;

namespace ProyectoFinal
{
    public abstract class AbstractHanderObtieneDiferenciaFechas : IObtieneDiferenciaFechas
    {
        private IObtieneDiferenciaFechas nextHandler;

        public IObtieneDiferenciaFechas NextNivel(IObtieneDiferenciaFechas _Handler)
        {
            nextHandler = _Handler;

            return nextHandler;
        }

        //public virtual string ObtenerDiferenciaFechas(DateTime _FechaBase, DateTime _FechaComparar)
        public virtual string ObtenerDiferenciaFechas()
        {
            if (nextHandler != null)
            {
                return nextHandler.ObtenerDiferenciaFechas();
                //return nextHandler.ObtenerDiferenciaFechas(_FechaBase, _FechaComparar);
            }
            else
            {
                return null;
            }
        }
    }
}
