using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clases
{
    public class ConcreteProductMacCheckBox : IAbstractProductCheckBox
    {
        public string CrearCheckbox()
        {
            return "Se creó el checkbox para Mac";
        }

        public string OtraFuncion(IAbstractProductButton boton)
        {
            var result = boton.CrearBoton();

            return $"Se creó un checkbox para mac a partir de un boton, ({result})";
        }
    }
}
