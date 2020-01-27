using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Mensajes
    {

        public void printVerde(string cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cMensaje);
        }

        public void printRojo(string cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(cMensaje);
        }

        public void printAmarillo(string cMensaje)
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(cMensaje);
        }
    }
}
