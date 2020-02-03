using System;

namespace ProyectoFinal
{
    public class MensajeAmarillo : IMensaje
    {
        public void Print(string cMensaje)
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(cMensaje);
        }
    }
}
