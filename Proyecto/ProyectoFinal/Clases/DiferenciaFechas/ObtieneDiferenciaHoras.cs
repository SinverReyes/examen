using System;

namespace ProyectoFinal
{
    public class ObtieneDiferenciaHoras : AbstractHanderObtieneDiferenciaFechas
    {
        private TimeSpan DiferenciaHoras;

        public ObtieneDiferenciaHoras(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            //DiferenciaHoras = _dtFechaActual - _dtFechaEntrega;
            DiferenciaHoras = _dtFechaEntrega - _dtFechaActual;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaHoras = DiferenciaHoras.Hours;

            if (iDiferenciaHoras != 0)
            {
                return ObtenerMensajeDiferenciaHoras(iDiferenciaHoras);
            }
            else
            {
                return base.ObtenerDiferenciaFechas();

            }
        }

        private string ObtenerMensajeDiferenciaHoras(int _iDiferenciaHoras)
        {
            string cMensaje = _iDiferenciaHoras > 0 ? "+," : "-,";

            int iAbsoluteValor = Math.Abs(_iDiferenciaHoras);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 hora"; break;
                default: cMensaje += iAbsoluteValor + " horas"; break;
            }

            return cMensaje;
        }
    }
}
