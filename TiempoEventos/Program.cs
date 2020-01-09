using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace TiempoEventos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");

            string rutaArchivo = "C:/Users/sinver.reyes/source/repos/TiempoEventos/Eventos.txt";

            string FechaActual = GetFechaActual();

            List<Evento> cContenidoArchivo = leerArchivo(rutaArchivo);


            Principal(FechaActual, cContenidoArchivo);

            Console.ReadKey();
            
        }

        public static void Principal(string FechaActual, List<Evento> cContenidoArchivo)
        {
            var _nombresEvento = cContenidoArchivo.Select(x => x.cNombreEvento).ToString();
            var _fechaEvento = cContenidoArchivo.Select(x => x.dtFechaEvento).ToString();

            int dia = int.Parse(FechaActual.Split('/')[0]);
            int mes = int.Parse(FechaActual.Split('/')[1]);
            int año = int.Parse(FechaActual.Split('/')[2]);

            foreach (var eventos in cContenidoArchivo)
            {
                int diaE = int.Parse(eventos.dtFechaEvento.Split('/')[0]);
                int mesE = int.Parse(eventos.dtFechaEvento.Split('/')[1]);
                int añoE = int.Parse(eventos.dtFechaEvento.Split('/')[2]);

                if (año != añoE)
                {
                    int diferencia = año - añoE;
                    Imprimir("El evento " + eventos.cNombreEvento + " fue hace " + Math.Abs(diferencia) + " años");
                }
                else
                {
                    if (mes != mesE)
                    {
                        int diferencia = mes - mesE;
                        Imprimir("El evento " + eventos.cNombreEvento + " fue hace " + Math.Abs(diferencia) + " meses");
                    }
                    else{
                        int diferencia = dia - diaE;
                        Imprimir("El evento " + eventos.cNombreEvento + " fue hace " + Math.Abs(diferencia) + " dias");
                    }
                }         
            }
        }

        public static string GetFechaActual()
        {
            DateTime _FechaActual = DateTime.UtcNow;
                
          
            return _FechaActual.ToString("dd/MM/yyyy");
        }

        public static List<Evento> leerArchivo(string _rutaArchivo) 
        {
            string linea;
            int cont = 0;
            List<Evento> datos = new List<Evento>();
            StreamReader sr = new StreamReader(_rutaArchivo);
            while ((linea = sr.ReadLine()) != null)
            {
                string cnombre = linea.Split(',')[0];
                string dtFechaEvento = linea.Split(',')[1];

                datos.Add(new Evento
                {
                    cNombreEvento = cnombre,
                    dtFechaEvento = dtFechaEvento
                }); ; ; 
                
                cont++;
            }
            sr.Close();

            return datos;
        }
               

        public static void Imprimir(string _cMensaje)
        {
            Console.WriteLine(_cMensaje);
        }
       
    }
   
}
