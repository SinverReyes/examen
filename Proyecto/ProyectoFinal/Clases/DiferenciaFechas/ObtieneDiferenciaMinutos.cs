using System;

namespace ProyectoFinal
{
    public class ObtieneDiferenciaMinutos : AbstractHanderObtieneDiferenciaFechas
    {
        private TimeSpan DiferenciaMinutos;

        public ObtieneDiferenciaMinutos(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            //DiferenciaMinutos = _dtFechaActual - _dtFechaEntrega;
            DiferenciaMinutos = _dtFechaEntrega - _dtFechaActual;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaMinutos = DiferenciaMinutos.Minutes;

            if (iDiferenciaMinutos != 0)
            {
                return ObtenerMensajeDiferenciaMinutos(iDiferenciaMinutos);
            }
            else
            {
                return "+,justo ahora";
            }
        }

        private string ObtenerMensajeDiferenciaMinutos(int _iDiferenciaMinutos)
        {
            string cMensaje = _iDiferenciaMinutos > 0 ? "+," : "-,";
            int iAbsoluteValor = Math.Abs(_iDiferenciaMinutos);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 minuto"; break;
                default: cMensaje += iAbsoluteValor + " minutos"; break;
            }

            return cMensaje;
        }
    }
}
