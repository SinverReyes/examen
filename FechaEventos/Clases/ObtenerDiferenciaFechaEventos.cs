using FechaEventos.Interfaces;
using System;
using System.Collections.Generic;
using TiempoEventos;

namespace FechaEventos.Clases
{
    public class ObtenerDiferenciaFechaEventos
    {
        public void ObtenerEventosPasadosFuturos()
        {
            IArchivos archivos = new ObtenerInfoArchivoTXT();

            string cRutaArchivo = archivos.ObtenerRutaArchivo();

            var lstEventos = archivos.LeerArchivo(cRutaArchivo);

            Calculardiferencia(lstEventos);

            VolveraIniciar();
        }

        private static DateTime FechaBase()
        {
            DateTime _FechaBase = DateTime.Now;

            return _FechaBase;
        }

        private static string EventoHaPasado(TimeSpan _interval)
        {

            string EventoYaOcurrio = _interval.ToString().Substring(0, 1);

            EventoYaOcurrio = EventoYaOcurrio == "-" ? "ocurrió hace" : "ocurrirá dentro de";

            return EventoYaOcurrio;
        }

        private static void Calculardiferencia(List<Evento> _lstEventos)
        {
            IImprimirEvento  ImprimirMensajeEvento = new ImprimirEvento();
            DateTime dtFechaEstatica = FechaBase();
            DateTime dtFechaEvento = new DateTime();
            string cYaOcurrio = "";
            string cNombreEvento = "";

            foreach (var lstEventos in _lstEventos)
            {
                cNombreEvento = lstEventos.cNombreEvento;
                dtFechaEvento = lstEventos.dtFechaEvento;

                TimeSpan interval = dtFechaEvento - dtFechaEstatica;

                cYaOcurrio = EventoHaPasado(interval);

                int Dias = Math.Abs(interval.Days);
                int meses = Math.Abs((Dias / 31));
                int Min = Math.Abs(interval.Minutes);
                int Hrs = Math.Abs(interval.Hours);

                string _cPeriodoTiempo = ObtenerPeriodoTiempo(meses, Dias, Hrs, Min);

                ImprimirMensajeEvento.PrintMensajeEvento(cNombreEvento, cYaOcurrio, _cPeriodoTiempo);
            }
        }

        private static string ObtenerPeriodoTiempo(int _meses, int _Dias, int _Hrs, int _Min)
        {
            string cPeriodoTiempo = "";

            if (_meses > 0)
            {
                cPeriodoTiempo = _meses == 1 ? "1 mes" : (_meses + " meses");
            }
            if (_meses == 0 && _Dias > 0)
            {
                cPeriodoTiempo = _Dias == 1 ? "1 día" : (_Dias + " días");
            }
            if (_meses == 0 && _Dias == 0 && _Hrs > 0)
            {
                cPeriodoTiempo = _Hrs == 1 ? "1 hora" : (_Hrs + " horas");
            }
            if (_meses == 0 && _Dias == 0 && _Hrs == 0 && _Min >= 0)
            {
                cPeriodoTiempo = _Min == 1 ? "1 minuto" : (_Min + " minutos");
            }

            return cPeriodoTiempo;
        }
        
        private void VolveraIniciar()
        {
            IImprimirSimple Impresionessimples = new ImprimirSimple();
            ICerrarConsola CerrarConsole = new CloseConsole();

            Impresionessimples.print("Presione una tleca para continuar o 0 <cero> para cerrar consola");
            string cRespuesta = Console.ReadLine();
            if (cRespuesta != "0")
            {
                Console.Clear();
                ObtenerEventosPasadosFuturos();
            }
            else
            {
                CerrarConsole.CerrarConsola();
            }
        }        
    }
}
