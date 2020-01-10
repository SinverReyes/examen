using System;
using System.Collections.Generic;
using System.IO;
using FechaEventos.Interfaces;
using TiempoEventos;

namespace FechaEventos.Clases
{
    public class ObtenerInfoArchivoTXT : IArchivos
    {
        public ObtenerInfoArchivoTXT()
        {
        }

        public List<Evento> FomatearDatosArchivo(StreamReader _sr, List<Evento> _datos)
        {
            IImprimirSimple ImprimirMensajeSimple = new ImprimirSimple();
            string linea;
            int cont = 0;
            try
            {
                while ((linea = _sr.ReadLine()) != null)
                {
                    string cnombre = linea.Split(',')[0];
                    DateTime dtFechaEvento = DateTime.Parse(linea.Split(',')[1]);

                    _datos.Add(new Evento
                    {
                        cNombreEvento = cnombre,
                        dtFechaEvento = dtFechaEvento
                    });

                    cont++;
                }
            }
            catch (Exception) { ImprimirMensajeSimple.print("El formato de los datos del archivo no es el correcto"); }
            return _datos;
        }

        public List<Evento> LeerArchivo(string _rutaArchivo)
        {
            IImprimirSimple ImprimirMensajeSimple = new ImprimirSimple();
            List<Evento> datos = new List<Evento>();
            try
            {
                StreamReader sr = new StreamReader(_rutaArchivo);

                datos = FomatearDatosArchivo(sr, datos);

                sr.Close();
            }
            catch (FileNotFoundException)
            {
                ImprimirMensajeSimple.print("No se encontró el archivo, introduzca una ruta valida");
            }
            catch (NotSupportedException)
            {
                ImprimirMensajeSimple.print("No se puede leer el archivo");
            }
            catch (ArgumentException)
            {
                ImprimirMensajeSimple.print("Debe de Ingresar una ruta");
            }

            return datos;
        }

        public string ObtenerRutaArchivo()
        {
            string ruta;

            Console.WriteLine("Ingrese la ruta de su archivo");

            ruta = Console.ReadLine();

            return ruta;
        }
                
    }
}
