using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class DiferenciaFechasBusiness
    {
        public string obtenerDiferenciaFechas(DateTime _dtFechaEntrega, DateTime _dtFechaHoy )
        {
            var meses = new ObtieneDiferenciaMeses(_dtFechaEntrega, _dtFechaHoy);
            var dias = new ObtieneDiferenciaDias(_dtFechaEntrega, _dtFechaHoy);
            var horas = new ObtieneDiferenciaHoras(_dtFechaEntrega, _dtFechaHoy);
            var minutos = new ObtieneDiferenciaMinutos(_dtFechaEntrega, _dtFechaHoy);

            meses.NextNivel(dias).NextNivel(horas).NextNivel(minutos);

            string result = meses.ObtenerDiferenciaFechas();

            return result;
        }
    }
}
