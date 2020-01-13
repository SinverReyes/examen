using Aplicacion_Eventos_3.Interfaces;
using System;

namespace Aplicacion_Eventos_3.Clases
{
    public class CompararDosFechas : ICompararDosFechas
    {
        public int CompararFechas(DateTime _dtFechaBase, DateTime _dtFechaComparar, string _cPeriodo)
        {
            int diferencia = 0;

            TimeSpan interval = _dtFechaComparar - _dtFechaBase;

            switch (_cPeriodo)
            {
                case "Mes": diferencia = (interval.Days / 30); break;
                case "Dia": diferencia = interval.Days; break;
                case "Hora": diferencia = interval.Hours; break;
                case "Minuto": diferencia = interval.Minutes; break;
            }

            return diferencia;
        }
    }
}
