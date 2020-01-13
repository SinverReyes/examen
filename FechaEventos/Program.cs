using System;
using System.Collections.Generic;
using TiempoEventos;
using FechaEventos.Clases;
using FechaEventos.Interfaces;

namespace FechaEventos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IImprimirSimple nuevoimprime = new ImprimirSimple();
            IArchivos nuevoArchivo = new ObtenerInfoArchivoTXT(nuevoimprime);
            ObtenerDiferenciaFechaEventos nuevo = new ObtenerDiferenciaFechaEventos(nuevoArchivo);

            nuevo.ObtenerEventosPasadosFuturos();
        }
    }
}
