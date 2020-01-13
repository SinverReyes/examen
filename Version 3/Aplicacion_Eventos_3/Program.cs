using Aplicacion_Eventos_3.Clases;
using Aplicacion_Eventos_3.Controladores;
using Aplicacion_Eventos_3.DTO;
using Aplicacion_Eventos_3.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aplicacion_Eventos_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Iniciar();
        }

        public static void Iniciar() 
        {
            #region Interfacez
            IImprimirMensajeSimple msgSimple = new ImprimirMensajeSimple();
            IFinalizarPrograma FinProgram = new FinalizarPrograma();
            ILimpiarConsola limpiarConsola = new LimpiarConsola();
            ILeerConsola leerConsola = new LeerConsola();
            IValidaRutaArchivo validarArchivo = new ValidaRutaArchivo();
            IValidarFecha validarFecha = new ValidarFecha();
            IObtenerInfoArchivo obtenerInfoArchivo = new ObtenerInfoArchivo(validarFecha);
            IFechaBase fechaBase = new FechaBase();
            IEventoOcurrido eventoOcurrido = new EventoOcurrido();
            IImprimirMensajeEvento imprimirMensajeEvento = new ImprimirMensajeEvento();
            #endregion

            #region variables
            string msgEventoHaPasado, cValorDiferencia, cRuta, tempDiferencia;
            int iValorDiferencia;
            #endregion

            ObtenerDiferenciaFechaEvento program = new ObtenerDiferenciaFechaEvento(msgSimple, FinProgram, limpiarConsola);

            try
            {
                cRuta = program.LeerRutaArchivo(leerConsola);

                StreamReader sr = program.validarArchivo(validarArchivo, cRuta);

                List<Eventos> lstEventos = program.ObtenerDatosArchivoTxt(obtenerInfoArchivo, sr);

                DateTime FechaBase = program.ObtenerFechaBase(fechaBase, "");

                foreach (var _lstEventos in lstEventos)
                {
                    tempDiferencia = DiferenciaFechas(FechaBase, _lstEventos.dtFechaEvento, program);

                    cValorDiferencia = tempDiferencia.Split(',')[1];

                    iValorDiferencia = int.Parse(tempDiferencia.Split(',')[0]);

                    msgEventoHaPasado = program.EventoOcurrido(eventoOcurrido, iValorDiferencia);

                    imprimirMensajeEvento.PrintMensajeEvento(_lstEventos.cNombreEvento, msgEventoHaPasado, cValorDiferencia);
                }

                program.ContinuarOTerminarProgram();
            }
            catch(Exception e)
            {
                msgSimple.PrintMensajeSimple(e.Message);
                program.ContinuarOTerminarProgram();
            }

            Iniciar();
        }

        public static string DiferenciaFechas(DateTime _FechaBase, DateTime _dtFechaEvento, ObtenerDiferenciaFechaEvento program)
        {
            ICompararDosFechas compararDosFechas = new CompararDosFechas();
            IObtenerDiferenciaFechas obtenerDiferenciaFechas = new ObtenerDiferenciaFechas(compararDosFechas);

            string valorDiferencia;           
          
            valorDiferencia = program.DiferenciaMeses(obtenerDiferenciaFechas, _FechaBase, _dtFechaEvento);
            
            return valorDiferencia;
        }        
    }
}
