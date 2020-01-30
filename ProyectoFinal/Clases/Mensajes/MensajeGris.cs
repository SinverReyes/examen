using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class MensajeGris : IMensaje
    {
        public void Print(string cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(cMensaje);
        }
    }
}
