using Strategy.Clases;
using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el nombre de la imagen:  ");
            string cNombreImg = Console.ReadLine();

            var opt = printMenu();
            var instancia = opciones(opt);

            string msg = instancia.SaveImg(cNombreImg);

            printMsg(msg);

            Console.ReadKey();
        }

        private static void printMsg(string msgImagen)
        {
            Console.WriteLine("Se ha guardado la imagen {0}", msgImagen);
        }

        public static string printMenu()
        {
            Console.WriteLine("\nEliga el formato en que desea guardar la imagen" +
                "\n1. PNG" +
                "\n2. JPG" +
                "\n3. GIF");
            string opt = Console.ReadLine();

            return opt;
        }

        public static void reiniciar(string _mensaje)
        {
            Console.WriteLine(_mensaje);
            printMenu();
        }

        public static IGuardarImagen opciones(string _opt)
        {
            IGuardarImagen Instancia = null;

            switch (_opt)
            {
                case "1":
                    Instancia = new StrategyPNG();
                    break;
                case "2":
                    Instancia = new StrategyJPG();
                    break;
                case "3":
                    Instancia = new StrategyGIF();
                    break;
                default: reiniciar("Elija una opción correcta"); break;
            }

            return Instancia;
        }
    }
}
