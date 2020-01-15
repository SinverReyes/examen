using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    public class Compilar : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Compilando ....");
        }
    }
}
