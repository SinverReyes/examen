using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    public class PruebasUnitarias : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Ejecutando Pruebas Unitarias. . .");
        }
    }
}
