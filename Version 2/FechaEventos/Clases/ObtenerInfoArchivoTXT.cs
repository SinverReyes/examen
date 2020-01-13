using System;
using System.Collections.Generic;
using System.IO;
using FechaEventos.Interfaces;
using TiempoEventos;

namespace FechaEventos.Clases
{
    public class ObtenerInfoArchivoTXT : IArchivos
    {
        private readonly IImprimirSimple printsimple;

        public ObtenerInfoArchivoTXT(IImprimirSimple Printsimple)
        {
            printsimple = Printsimple;
        }

        public List<Evento> FomatearDatosArchivo(StreamReader _sr, List<Evento> _datos)
        {
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
            catch (Exception) { printsimple.print("El formato de los datos del archivo no es el correcto"); }
            return _datos;
        }

        public List<Evento> LeerArchivo(string _rutaArchivo)
        {
            List<Evento> datos = new List<Evento>();
            try
            {
                StreamReader sr = new StreamReader(_rutaArchivo);

                datos = FomatearDatosArchivo(sr, datos);

                sr.Close();
            }
            catch (FileNotFoundException)
            {
                printsimple.print("No se encontró el archivo, introduzca una ruta valida");
            }
            catch (NotSupportedException)
            {
                printsimple.print("No se puede leer el archivo");
            }
            catch (ArgumentException)
            {
                printsimple.print("Debe de Ingresar una ruta");
            }

            return datos;
        }

        public string ObtenerRutaArchivo()
        {
            string ruta;

            printsimple.print("Ingrese la ruta de su archivo");

            ruta = Console.ReadLine();

            return ruta;
        }
                
    }
}
