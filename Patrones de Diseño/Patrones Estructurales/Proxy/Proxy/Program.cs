using System;
using System.Threading;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Inicio();

            Console.ReadKey();
        }

        private static int LeerLlave()
        {
            int iLlave = 0;
            try
            {
                Console.WriteLine("Introduzca la llave para encender el carro");
                iLlave = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("La llave debe contener solo numeros enteros");
                LeerLlave();
            }

            return iLlave;
        }

        private static void Inicio()
        {
            //Leyendo la llave del carro
            int illave = LeerLlave();
            
            Carro Carro = new Carro();
            Proxy proxy = new Proxy(Carro);
            proxy.Encender(illave);

            ReinsertarLlave();
        }

        private static void ReinsertarLlave()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Presione 0 para salir u otra tecla para insertar otra llave");
            string opt = Console.ReadLine();

            if (opt=="0")
            {
                Environment.Exit(-1);
            }
            else
            {
                Console.Clear();
                Inicio();
            }
        }
    }
}
