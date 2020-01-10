using System;
using System.Collections.Generic;
using System.IO;
using FechaEventos.Interfaces;
using TiempoEventos;

namespace FechaEventos.Clases
{
    public class ObtenerInfoArchivoTXT : IArchivos, IImpresiones, ICerrarConsola
    {
        public ObtenerInfoArchivoTXT()
        {
        }

        public void CerrarConsola()
        {
            Environment.Exit(-1);
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
            catch (Exception) { print("El formato de los datos del archivo no es el correcto"); }
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
                print("No se encontró el archivo, introduzca una ruta valida");
            }
            catch (NotSupportedException)
            {
                print("No se puede leer el archivo");
            }
            catch (ArgumentException)
            {
                print("Debe de Ingresar una ruta");
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

        public void print(string _Mensajes)
        {
            Console.WriteLine(_Mensajes);
        }        
        
    }
}
