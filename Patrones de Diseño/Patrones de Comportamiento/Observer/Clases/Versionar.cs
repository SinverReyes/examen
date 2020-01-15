using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    public class Versionar : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Versionando Código...");
        }
    }
}
