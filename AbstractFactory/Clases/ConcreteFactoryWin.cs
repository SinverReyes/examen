using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clases
{
    public class ConcreteFactoryWin : IAbstractFactory
    {
        public IAbstractProductButton CreateButton()
        {
            return new ConcreteProductWinButton();
        }

        public IAbstractProductCheckBox CreateCheckBox()
        {
            return new ConcreteProductWinCheckBox();
        }
    }
}
