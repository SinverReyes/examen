using System;

namespace ProyectoFinal
{
    public class ObtieneDiferenciaAnios : AbstractHanderObtieneDiferenciaFechas
    {
        private TimeSpan DiferenciaAnios;

        public ObtieneDiferenciaAnios(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            DiferenciaAnios = _dtFechaEntrega - _dtFechaActual;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaAnios = (DiferenciaAnios.Days/364);

            if (iDiferenciaAnios != 0)
            {
                return ObtenerMensajeDiferenciaAnios(iDiferenciaAnios);
            }
            else
            {
                return base.ObtenerDiferenciaFechas();
            }
        }

        private string ObtenerMensajeDiferenciaAnios(int _iDiferenciaAnios)
        {
            string cMensaje = _iDiferenciaAnios > 0 ? "+," : "-,";

            int iAbsoluteValor = Math.Abs(_iDiferenciaAnios);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 año"; break;
                default: cMensaje += iAbsoluteValor + " años"; break;
            }

            return cMensaje;
        }
    }
}
