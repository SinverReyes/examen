using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clases
{
    public class ConcreteProductWinButton : IAbstractProductButton
    {
        public string CrearBoton()
        {
            return "Se creó el botón para windows.";
        }
    }
}
