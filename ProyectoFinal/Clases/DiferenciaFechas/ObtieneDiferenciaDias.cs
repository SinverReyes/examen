using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ObtieneDiferenciaDias : AbstractHanderObtieneDiferenciaFechas
    {
        private TimeSpan DiferenciaDias;

        public ObtieneDiferenciaDias(DateTime _dtFechaBase, DateTime _dtFechaComparar)
        {
            DiferenciaDias = _dtFechaBase - _dtFechaComparar;
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
