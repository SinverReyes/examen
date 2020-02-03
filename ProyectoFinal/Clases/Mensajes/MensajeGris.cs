using System;

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
