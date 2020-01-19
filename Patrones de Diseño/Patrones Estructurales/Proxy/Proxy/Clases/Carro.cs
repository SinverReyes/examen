using System;
using System.Threading;

namespace Proxy
{
    public class Carro : ILlave
    {
        public void Encender(int _iLlave)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Carro: Encendiendo el carro.");
        }
    }
}
