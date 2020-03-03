using System;

namespace ProyectoFinal
{
    public class ObtieneDiferenciaBimestres : AbstractHanderObtieneDiferenciaFechas
    {
        private TimeSpan DiferenciaBimestres;

        public ObtieneDiferenciaBimestres(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            DiferenciaBimestres = _dtFechaEntrega - _dtFechaActual;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaBimestres = (DiferenciaBimestres.Days/60);

            if (iDiferenciaBimestres != 0)
            {
                return ObtenerMensajeDiferenciaBimestres(iDiferenciaBimestres);
            }
            else
            {
                return base.ObtenerDiferenciaFechas();
            }
        }

        private string ObtenerMensajeDiferenciaBimestres(int _iDiferenciaBimestres)
        {
            string cMensaje = _iDiferenciaBimestres > 0 ? "+," : "-,";

            int iAbsoluteValor = Math.Abs(_iDiferenciaBimestres);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 bimestre"; break;
                default: cMensaje += iAbsoluteValor + " bimestres"; break;
            }

            return cMensaje;
        }
    }
}
