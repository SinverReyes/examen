using Aplicacion_Eventos_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Eventos_3.Clases
{
    public class ImprimirMensajeSimple : IImprimirMensajeSimple
    {
        public void PrintMensajeSimple(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
