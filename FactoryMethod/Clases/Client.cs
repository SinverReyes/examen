using System;

namespace FactoryMethod.Clases
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Ejecutado en Windows.");
            ClientCode(new MensajeWindows());

            Console.WriteLine("");

            Console.WriteLine("App: Ejecutado en Web.");
            ClientCode(new MensajeWeb());
        }

        public void ClientCode(Messaje Messaje)
        {
            Console.WriteLine("Client: Muestrame el mensaje\n" + Messaje.SomeOperation());
        }
    }
}
