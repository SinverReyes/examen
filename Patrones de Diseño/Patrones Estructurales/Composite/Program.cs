using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   
    public class Program
    {
        static void Main(string[] args)
        {
           iniciar();

            Console.ReadKey();
        }

        public static void iniciar()
        {
           new Cliente().ObtenerTotales();
        }
    }
}
