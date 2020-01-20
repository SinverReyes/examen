using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio();

            Console.ReadKey();
        }


        private static void inicio()
        {
            int idCxP = obtenerIdCxP();
            int importeCxP = obtenerImporteCxP();
            int iNaturaleza = obtenerNaturalezaCxP();

            GuardarCxPService save = new GuardarCxPService();
            save.GuardadoCxP(idCxP, importeCxP, iNaturaleza);
        }

        private static int obtenerIdCxP()
        {
            int iRespuesta = 0;
            try
            {
                Print("Ingresa el id de la cxp ");
                iRespuesta = leerInt();
            }
            catch (Exception e)
            {
                Print(e.Message);
                obtenerIdCxP();
            }

            return iRespuesta;
        }

        private static int obtenerImporteCxP()
        {
            int iRespuesta = 0;
            try
            {
                Print("Ingresa el importe de la cxp ");
                iRespuesta = leerInt();
            }
            catch (Exception e)
            {
                Print(e.Message);
                obtenerImporteCxP();
            }

            return iRespuesta;
        }

        private static int obtenerNaturalezaCxP()
        {
            int iRespuesta = 0;
            try
            {
                Print("Ingresa la naturaleza de la cxp\n1. Suma\n0. Resta");
                iRespuesta = leerInt();
                if (iRespuesta > 1 || iRespuesta < 0)
                {
                    Print("Solo puede seleccionar 1 o 0\n");
                    obtenerNaturalezaCxP();
                }
            }
            catch (Exception e)
            {
                Print(e.Message);
                obtenerNaturalezaCxP();
            }

            return iRespuesta;
        }

        private static int leerInt()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Solo se permiten numeros enteros");
            }
        }

        private static void Print(string _cMensaje)
        {
            Console.WriteLine(_cMensaje);
        }
    }
}
