using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandPractice
{
    public class Program
    {
        static bool lHabilidadExtra1 = false;
        static bool lHabilidadExtra2 = false;
        static string menuPrincipal = "Estas son las acciones que puede realizar el usuario\n" +
                                "1. Caminar\n" +
                                "2. Saltar\n" +
                                "3. Golpear\n" +
                                "4. Disparar Pistola\n";
        static string OpcionesExtraMenu1 = "5. Conseguir Lanzagranadas\n";
        static string OpcionesExtraMenu2 = "6. Conseguir Rifle de Plasma\n";

        static void Main(string[] args)
        {
            try
            {
                Iniciar();
            }
            catch (Exception e)
            {
                print(e.Message);
            }

            Console.ReadKey();
        }

        public static void Iniciar()
        {
            int optMenuGuerreros = MenuGuerreros();

            print("Ingrese su nombre");
            string cNombrePersonaje = leerString();

            int optMenuPrincipal = MenuPrincipal();

            Cliente client = new Cliente();
            client.RealizarAccion(optMenuGuerreros, optMenuPrincipal, cNombrePersonaje);
        }

        public static int MenuPrincipal()
        {
            string optextramenu1 = "5. Lanzar Granada\n";
            string optextramenu2 = "6. Disparar Rifle de Plasma\n";
            string menuTemporal = "";

            if (lHabilidadExtra1 && lHabilidadExtra2 == false)
            {
                menuTemporal = menuPrincipal + optextramenu1 + OpcionesExtraMenu2;
            }

            if (lHabilidadExtra2 && lHabilidadExtra1 == false)
            {
                menuTemporal = menuPrincipal + OpcionesExtraMenu1 + optextramenu2;
            }

            if (lHabilidadExtra1 && lHabilidadExtra2)
            {
                menuTemporal = menuPrincipal + optextramenu1 + optextramenu2;
            }

            if (lHabilidadExtra1 == false && lHabilidadExtra2 == false)
            {
                menuTemporal = menuPrincipal + OpcionesExtraMenu1 + OpcionesExtraMenu2;
            }

            print(menuTemporal);
            return ObtenerOpcionMenurincipal();
        }

        public static int ObtenerOpcionMenurincipal()
        {
            int opt = leerInt();

            if (opt == 5 && lHabilidadExtra1 == false)
            {
                lHabilidadExtra1 = true;
                reimprimirMenuAcciones("lanzar Granadas");
            }

            if (opt == 6 && lHabilidadExtra2 == false)
            {
                lHabilidadExtra2 = true;
                reimprimirMenuAcciones("disparar con el Rifle de Plasma");
            }

            if (opt > 6 || opt <= 0)
            {
                print("Solo se permite ingresar los valores del menú");
                MenuPrincipal();
            }

            return opt;
        }

        public static int MenuGuerreros()
        {
            int opt = 0;
            string menu = "Seleccione al guerrero\n" +
                            "1. Guerrero de Clase Baja - 10\n" +
                            "2. Guerrero de Clase Media - 20\n" +
                            "3. Guerrero de Clase Alta - 30";
            print(menu);

            try
            {
                opt = leerInt();

                if (opt > 3 || opt < 0)
                {
                    print("Debe proporcionar una de las opciones del menu");
                    MenuGuerreros();
                }
            }
            catch (Exception e)
            {
                print(e.Message);
                MenuGuerreros();
                //opt = leerInt();
            }

            return opt;
        }

        public static void reimprimirMenuAcciones(string mensaje)
        {
            
            print("\nFelicidades, ahora puedes " + mensaje + "\nRecargando menú. . . ");
            Thread.Sleep(3000);
            Console.Clear();
            MenuPrincipal();
        }

        private static void print(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        private static string leerString()
        {
            return Console.ReadLine(); ;
        }

        private static int leerInt()
        {
            try
            {
                return int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                throw new Exception("El valor introducido no es un entero");
            }
        }
    }
}
