using System;

namespace ProyectoFinal
{
    public class MensajeRojo : IMensaje
    {
        public void Print(string cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(cMensaje);
        }
    }
}
