using Aplicacion_Eventos_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Eventos_3.Clases
{
    public class ObtenerDiferenciaFechas : IObtenerDiferenciaFechas
    {
        private ICompararDosFechas compararFechas;
        public ObtenerDiferenciaFechas(ICompararDosFechas _compararFechas)
        {
            compararFechas = _compararFechas;
        }

        public int ObtenerDiferenciaDias(DateTime dtFechaBase, DateTime dtFechaComparar)
        {
            int resultado;

            resultado = compararFechas.CompararFechas(dtFechaBase, dtFechaComparar, "Dia");

            return resultado;
        }

        public int ObtenerDiferenciaHoras(DateTime dtFechaBase, DateTime dtFechaComparar)
        {
            int resultado;

            resultado = compararFechas.CompararFechas(dtFechaBase, dtFechaComparar, "Hora");

            return resultado;
        }

        public int ObtenerDiferenciaMes(DateTime dtFechaBase, DateTime dtFechaComparar)
        {
            int resultado;

            resultado = compararFechas.CompararFechas(dtFechaBase, dtFechaComparar, "Mes");

            return resultado;
        }

        public int ObtenerDiferenciaMinutos(DateTime dtFechaBase, DateTime dtFechaComparar)
        {
            int resultado;

            resultado = compararFechas.CompararFechas(dtFechaBase, dtFechaComparar, "Minuto");

            return resultado;
        }
    }
}
