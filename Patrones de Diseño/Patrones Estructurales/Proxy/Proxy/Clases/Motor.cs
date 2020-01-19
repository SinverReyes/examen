using System;
using System.Threading;

namespace Proxy
{
    public class Motor : ILlave
    {
        public void Encender(int _iLlave)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Motor: Encendiendo el motor.");
        }
    }
}
