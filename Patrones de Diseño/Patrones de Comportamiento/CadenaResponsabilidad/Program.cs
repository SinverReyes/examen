using System;

namespace CadenaResponsabilidad
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Inicio();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Inicio();
            }

            Console.ReadKey();
        }

        private static void Inicio()
        {
            Console.WriteLine("Ingresa el monto de la compra");
            double dMonto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Concepto de la compra");
            string cConcepto = Console.ReadLine();

            ArmarCadenaResponsabilidad(dMonto, cConcepto);

            VolverIniciar();
        }

        public static void ArmarCadenaResponsabilidad(double _dCosto, string _cConcepto)
        {
            var Director = new Director();
            var Subdirector = new Subdirector();
            var Gerente = new Gerente();
            var Coordinador = new Coordinador();

            Coordinador.NextNivel(Gerente).NextNivel(Subdirector).NextNivel(Director);

            var a = new CompraAutorizada();
            a.main(Coordinador, _dCosto, _cConcepto);
        }

        private static void VolverIniciar()
        {
            Console.WriteLine("\n\nPara continuar presione cualquier tecla, para salir presione 0");
            string opt = Console.ReadLine();

            if (opt != "0")
            {
                Console.Clear();
                Inicio();
            }
            else
            {
                Environment.Exit(-1);
            }
        }
    }
}
