using Aplicacion_Eventos_3.Interfaces;
using System;

namespace Aplicacion_Eventos_3.Clases
{
    public class ImprimirMensajeEvento : IImprimirMensajeEvento
    {
        public void PrintMensajeEvento(string cEvento, string cEventoHaPasado, string cDiferenciaFechas)
        {
            string mensaje = "El evento " + cEvento + " " + cEventoHaPasado + " " + cDiferenciaFechas;
            Console.WriteLine(mensaje);
        }
    }
}
