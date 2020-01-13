using Aplicacion_Eventos_3.DTO;
using Aplicacion_Eventos_3.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Eventos_3.Controladores
{
    public class ObtenerDiferenciaFechaEvento : IReiniciarProgram
    {
        private IImprimirMensajeSimple msgSimple;
        private IFinalizarPrograma FinProgram;
        private ILimpiarConsola limpiarConsola;

        public ObtenerDiferenciaFechaEvento(IImprimirMensajeSimple _msgSimple, IFinalizarPrograma _FinProgram, ILimpiarConsola _limpiarConsola)
        {
            msgSimple = _msgSimple;
            FinProgram = _FinProgram;
            limpiarConsola = _limpiarConsola;
        }

        public string LeerRutaArchivo(ILeerConsola leer)
        {
            msgSimple.PrintMensajeSimple("Ingrese la ruta del archivo");
            string cRuta = leer.ReadConsola();

            return cRuta;
        }

        public StreamReader validarArchivo(IValidaRutaArchivo validarArchivo, string cRuta)
        {
            try
            {
                StreamReader sr = validarArchivo.ArchivoExiste(cRuta);
                return sr;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Eventos> ObtenerDatosArchivoTxt(IObtenerInfoArchivo obtenerInfoArchivo, StreamReader sr)
        {
            try
            {
                List<Eventos> lstEventos = obtenerInfoArchivo.ObtenerDatosArchivoTxt(sr);
                return lstEventos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                //msgSimple.PrintMensajeSimple(e.Message);
            }
        }

        public DateTime ObtenerFechaBase(IFechaBase fechaBase,string _FechaEspecifica)
        {
            try
            {
                DateTime FechaEspecifica = fechaBase.ObtenerFechaBase(_FechaEspecifica);
                return FechaEspecifica;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string DiferenciaMeses(IObtenerDiferenciaFechas obtenerDiferenciaFechas, DateTime _FechaBase, DateTime _dtFechaEvento)
        {
            string cResultado;
            int valor = obtenerDiferenciaFechas.ObtenerDiferenciaMes(_FechaBase, _dtFechaEvento);

            switch (Math.Abs(valor))
            {
                case 0:
                    cResultado = DiferenciaDias(obtenerDiferenciaFechas, _FechaBase, _dtFechaEvento);
                    break;
                case 1:
                    cResultado = valor + "," + Math.Abs(valor) + " mes";
                    break;
                default:
                    cResultado = valor + "," + Math.Abs(valor) + " meses";
                    break;
            }

            return cResultado;
        }

        public string DiferenciaDias(IObtenerDiferenciaFechas obtenerDiferenciaFechas, DateTime _FechaBase, DateTime _dtFechaEvento)
        {
            string cResultado;
            int valor = obtenerDiferenciaFechas.ObtenerDiferenciaDias(_FechaBase, _dtFechaEvento);

            switch (Math.Abs(valor))
            {
                case 0:
                    cResultado = DiferenciaHoras(obtenerDiferenciaFechas, _FechaBase, _dtFechaEvento);
                    break;
                case 1:
                    cResultado = valor + "," + Math.Abs(valor) + " día";
                    break;
                default:
                    cResultado = valor + "," + Math.Abs(valor) + " días";
                    break;
            }

            return cResultado;
        }

        public string DiferenciaHoras(IObtenerDiferenciaFechas obtenerDiferenciaFechas, DateTime _FechaBase, DateTime _dtFechaEvento)
        {
            string cResultado;
            int valor = obtenerDiferenciaFechas.ObtenerDiferenciaHoras(_FechaBase, _dtFechaEvento);

            switch (Math.Abs(valor))
            {
                case 0:
                    cResultado = DiferenciaMinutos(obtenerDiferenciaFechas, _FechaBase, _dtFechaEvento);
                    break;
                case 1:
                    cResultado = valor + "," + Math.Abs(valor) + " hora";
                    break;
                default:
                    cResultado = valor + "," + Math.Abs(valor) + " horas";
                    break;
            }
            
            return cResultado;
        }

        public string DiferenciaMinutos(IObtenerDiferenciaFechas obtenerDiferenciaFechas, DateTime _FechaBase, DateTime _dtFechaEvento)
        {
            string cResultado;
            int valor = obtenerDiferenciaFechas.ObtenerDiferenciaMinutos(_FechaBase, _dtFechaEvento);

            switch (Math.Abs(valor))
            {
                case 0:
                    cResultado = valor+", ";
                    break;
                case 1:
                    cResultado = valor + "," + Math.Abs(valor) + " minuto";
                    break;
                default:
                    cResultado = valor + "," + Math.Abs(valor) + " minutos";
                    break;
            }

            return cResultado;
        }

        public string EventoOcurrido(IEventoOcurrido eventoOcurrido, int iValor)
        {
            string cResultado = eventoOcurrido.MensajeEventoOcurrito(iValor);

            return cResultado;
        }

        public void ContinuarOTerminarProgram()
        {
            msgSimple.PrintMensajeSimple("Presione una tleca para continuar o 0 <cero> para cerrar consola");
            string cRespuesta = Console.ReadLine();
            if (cRespuesta != "0")
            {
                limpiarConsola.CleanConsole();
            }
            else
            {
                FinProgram.CerrarConsola();
            }
        }
    }
}
