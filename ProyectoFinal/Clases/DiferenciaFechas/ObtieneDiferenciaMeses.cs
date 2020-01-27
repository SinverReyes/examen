using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ObtieneDiferenciaMeses : AbstractHanderObtieneDiferenciaFechas
    {
        private TimeSpan DiferenciaMeses;

        public ObtieneDiferenciaMeses(DateTime _dtFechaBase, DateTime _dtFechaComparar)
        {
            DiferenciaMeses = _dtFechaBase - _dtFechaComparar;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaMeses = (DiferenciaMeses.Days / 30);

            if (iDiferenciaMeses != 0)
            {
                return ObtenerMensajeDiferenciaMeses(iDiferenciaMeses);
            }
            else
            {
                return base.ObtenerDiferenciaFechas();

            }
        }

        private string ObtenerMensajeDiferenciaMeses(int _iDiferenciaMeses)
        {
            string cMensaje = _iDiferenciaMeses > 0 ? " dentro de ": " hace ";
            int iAbsoluteValor = Math.Abs(_iDiferenciaMeses);

            switch (iAbsoluteValor)
            {
                case 1: cMensaje += "1 mes"; break;
                default: cMensaje += iAbsoluteValor + " meses"; break;
            }

            return cMensaje;
        }
    }
}
