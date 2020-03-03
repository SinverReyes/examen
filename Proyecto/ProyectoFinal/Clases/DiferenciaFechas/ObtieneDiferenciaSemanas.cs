using System;

namespace ProyectoFinal
{
    public class ObtieneDiferenciaSemanas : AbstractHanderObtieneDiferenciaFechas
    {
        private TimeSpan DiferenciaSemanas;

        public ObtieneDiferenciaSemanas(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            //DiferenciaSemanas = _dtFechaActual - _dtFechaEntrega;
            DiferenciaSemanas = _dtFechaEntrega - _dtFechaActual;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaSemanas = (DiferenciaSemanas.Days/7);

            if (iDiferenciaSemanas != 0)
            {
                return ObtenerMensajeDiferenciaSemanas(iDiferenciaSemanas);
            }
            else
            {
                return base.ObtenerDiferenciaFechas();
            }
        }

        private string ObtenerMensajeDiferenciaSemanas(int _iDiferenciaSemanas)
        {
            string cMensaje = _iDiferenciaSemanas > 0 ? "+," : "-,";

            int iAbsoluteValor = Math.Abs(_iDiferenciaSemanas);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 semana"; break;
                default: cMensaje += iAbsoluteValor + " semanas"; break;
            }

            return cMensaje;
        }
    }
}
