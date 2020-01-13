using FechaEventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaEventos.Clases
{
    public class ImprimirSimple: IImprimirSimple
    {
        public void print(string _Mensajes)
        {
            Console.WriteLine(_Mensajes);
        }
    }
}
