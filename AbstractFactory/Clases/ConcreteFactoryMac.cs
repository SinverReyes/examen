using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clases
{
    public class ConcreteFactoryMac : IAbstractFactory
    {
        public IAbstractProductButton CreateButton()
        {
            return new ConcreteProductMacButton();
        }

        public IAbstractProductCheckBox CreateCheckBox()
        {
            return new ConcreteProductMacCheckBox();
        }
    }
}
