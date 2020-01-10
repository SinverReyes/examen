using System;
using System.Collections.Generic;
using TiempoEventos;
using FechaEventos.Clases;

namespace FechaEventos
{
    public class Program : ObtenerDiferenciaFechaEventos
    {
        public static void Main(string[] args)
        {
            ObtenerDiferenciaFechaEventos nuevo = new ObtenerDiferenciaFechaEventos();

            nuevo.ObtenerEventosPasadosFuturos();
        }
    }
}
