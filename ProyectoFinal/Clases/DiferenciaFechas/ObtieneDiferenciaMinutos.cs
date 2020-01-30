using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ObtieneDiferenciaMinutos : AbstractHanderObtieneDiferenciaFechas
    {
        private TimeSpan DiferenciaMinutos;

        public ObtieneDiferenciaMinutos(DateTime _dtFechaBase, DateTime _dtFechaComparar)
        {
            DiferenciaMinutos = _dtFechaBase - _dtFechaComparar;
        }

        public override string ObtenerDiferenciaFechas()
        {
            int iDiferenciaMinutos = DiferenciaMinutos.Hours;

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
