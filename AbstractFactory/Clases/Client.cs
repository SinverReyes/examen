using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clases
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Cliente: Instanciando la fabrica de windows...");
            ClientMethod(new ConcreteFactoryWin());
            Console.WriteLine();

            Console.WriteLine("Cliente: Instanciando la fabrica de MACs...");
            ClientMethod(new ConcreteFactoryMac());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var _CrearBoton = factory.CreateButton();
            var _CrearCheckbox = factory.CreateCheckBox();

            Console.WriteLine(_CrearCheckbox.CrearCheckbox());
            Console.WriteLine(_CrearCheckbox.OtraFuncion(_CrearBoton));
        }
    }
}
