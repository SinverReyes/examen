using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IAbstractProductCheckBox
    {
        string CrearCheckbox();

        string OtraFuncion(IAbstractProductButton boton);
    }
}
