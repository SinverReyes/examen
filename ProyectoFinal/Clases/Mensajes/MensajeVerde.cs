using System;

namespace ProyectoFinal
{
    public class MensajeVerde : IMensaje
    {
        public void Print(string cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cMensaje);
        }
    }
}
