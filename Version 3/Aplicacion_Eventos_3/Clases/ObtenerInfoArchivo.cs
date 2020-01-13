using Aplicacion_Eventos_3.DTO;
using Aplicacion_Eventos_3.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aplicacion_Eventos_3.Clases
{
    public class ObtenerInfoArchivo : IObtenerInfoArchivo
    {
        private IValidarFecha validarFecha;
        public ObtenerInfoArchivo(IValidarFecha _validarFecha)
        {
            validarFecha = _validarFecha;
        }

        public List<Eventos> ObtenerDatosArchivoTxt(StreamReader archivo)
        {
            List<Eventos> lstEventos = new List<Eventos>();
            string linea;
            int cont = 0;

            try
            {
                while ((linea = archivo.ReadLine()) != null)
                {
                    string cnombre = linea.Split(',')[0];
                    string fechatemp = linea.Split(',')[1];

                    DateTime dtFechaEvento = validarFecha.ValidarFechaEvento(fechatemp);

                    lstEventos.Add(new Eventos
                    {
                        cNombreEvento = cnombre,
                        dtFechaEvento = dtFechaEvento
                    });

                    cont++;
                }

                archivo.ReadLine();

                return lstEventos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
