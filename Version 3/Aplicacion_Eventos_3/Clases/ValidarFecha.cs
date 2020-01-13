using Aplicacion_Eventos_3.Interfaces;
using System;

namespace Aplicacion_Eventos_3.Clases
{
    public class ValidarFecha : IValidarFecha
    {
        public DateTime ValidarFechaEvento(string cFecha)
        {
            try
            {
                DateTime dtFechaEvento = DateTime.Parse(cFecha);

                return dtFechaEvento;
            }
            catch (Exception)
            {
                throw new Exception ("La fecha no tiene un formato correcto");
            }

        }
    }
}
