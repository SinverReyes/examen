using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    public class Proxy : ILlave
    {
        private Carro _Carro;
        private Motor _Motor;

        public Proxy(Carro Carro)
        {
            _Carro = Carro;
        }

        public void Encender(int _iLlave)
        {
            if (ValidarLlaveEsCorrerta(_iLlave))
            {
                Thread.Sleep(2000);
                Console.WriteLine("La llave introducida es correcta. . . ");
                
                _Carro.Encender(_iLlave);

                _Motor = new Motor();
                _Motor.Encender(_iLlave);
            }
            else
            {
                Thread.Sleep(2000);
                Console.WriteLine("Proxy: La llave insertada no es la correcta");
            }
        }

        private bool ValidarLlaveEsCorrerta(int _iLlave)
        {

            int iLlave = 1234;
            Console.WriteLine("Proxy: Revisando que la llave sea la correcta.");

            return iLlave == _iLlave;
        }
    }
}
