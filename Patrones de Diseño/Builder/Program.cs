using Builder.Clases;
using System;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builderCarro = new ConcreteBuilderCarro();
            var builderManualCarro = new ConcreteBuilderManualCarro();

            ///El director ordena la construcción del carro
            director.Builder = builderCarro;

            Console.WriteLine("Construcción del carro");
            director.CarBuilder();//obtiene las tareas para la  construccion del carro
            Console.WriteLine(builderCarro.GetProduct().ListParts());

            ///El director ordena la creación del manual
            director.Builder = builderManualCarro;

            Console.WriteLine("Creando Manual del Carro");
            director.ManualCarBuilder();//obtiene las tareas para la documentación del manual
            Console.WriteLine(builderManualCarro.GetProduct().ListParts());

            Console.ReadKey();
        }
        
    }
}
