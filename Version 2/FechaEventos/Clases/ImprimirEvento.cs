using FechaEventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaEventos.Clases
{
    public class ImprimirEvento : IImprimirEvento
    {
        public void PrintMensajeEvento(string _cNombreEvento, string _cYaOcurrio, string _cPeriodo)
        {
            string mensaje = "El evento " + _cNombreEvento + " " + _cYaOcurrio + " " + _cPeriodo;
            Console.WriteLine(mensaje);
        }
    }
}
