using System;
using System.Threading;
using State.Clases;
using State.Interfaces;

namespace State
{
    public class Program
    {

        static void Main(string[] args)
        {
            var EstadoInicial = new AlarmaActivada();
            var context = new Alarma(EstadoInicial);
            EstadoInicial.SetContext(context);

            

            Console.WriteLine("-----<Activando alarma>-------");
            context.Activar();
            Console.WriteLine("-----<Desactivando alarma>----");
            Thread.Sleep(2000);
            context.Desactivar();
            Console.WriteLine("-----<Desactivando alarma>----");
            Thread.Sleep(2000);
            context.Desactivar();
            Console.WriteLine("-----<Activando alarma>-------");
            Thread.Sleep(2000);
            context.Activar();

            Console.ReadKey();
        }
    }
}
