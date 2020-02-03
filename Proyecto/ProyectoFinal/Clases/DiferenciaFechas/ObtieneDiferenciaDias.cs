using System;

namespace ProyectoFinal
{
    public class ObtieneDiferenciaDias : AbstractHanderObtieneDiferenciaFechas
    {
        private TimeSpan DiferenciaDias;

        public ObtieneDiferenciaDias(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            //DiferenciaDias = _dtFechaActual - _dtFechaEntrega;
            DiferenciaDias = _dtFechaEntrega - _dtFechaActual;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaDias = DiferenciaDias.Days;

            if (iDiferenciaDias != 0)
            {
                return ObtenerMensajeDiferenciaDias(iDiferenciaDias);
            }
            else
            {
                return base.ObtenerDiferenciaFechas();
            }
        }

        private string ObtenerMensajeDiferenciaDias(int _iDiferenciaDias)
        {
            string cMensaje = _iDiferenciaDias > 0 ? "+," : "-,";

            int iAbsoluteValor = Math.Abs(_iDiferenciaDias);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 día"; break;
                default: cMensaje += iAbsoluteValor + " días"; break;
            }

            return cMensaje;
        }
    }
}
