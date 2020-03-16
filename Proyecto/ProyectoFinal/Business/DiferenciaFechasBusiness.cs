using System;

namespace ProyectoFinal
{
    public class DiferenciaFechasBusiness
    {
        public string obtenerDiferenciaFechas(DateTime _dtFechaEntrega, DateTime _dtFechaHoy )
        {
            var anios = new ObtieneDiferenciaAnios(_dtFechaEntrega, _dtFechaHoy);
            var bimestres = new ObtieneDiferenciaBimestres(_dtFechaEntrega, _dtFechaHoy);
            var semanas = new ObtieneDiferenciaSemanas(_dtFechaEntrega, _dtFechaHoy);
            var meses = new ObtieneDiferenciaMeses(_dtFechaEntrega, _dtFechaHoy);
            var dias = new ObtieneDiferenciaDias(_dtFechaEntrega, _dtFechaHoy);
            var horas = new ObtieneDiferenciaHoras(_dtFechaEntrega, _dtFechaHoy);
            var minutos = new ObtieneDiferenciaMinutos(_dtFechaEntrega, _dtFechaHoy);

            anios.NextNivel(bimestres).NextNivel(meses).NextNivel(semanas).NextNivel(dias).NextNivel(horas).NextNivel(minutos);

            string result = anios.ObtenerDiferenciaFechas();

            return result;
        }
    }
}
