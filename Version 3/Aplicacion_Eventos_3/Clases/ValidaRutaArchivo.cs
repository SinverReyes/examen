using Aplicacion_Eventos_3.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Eventos_3.Clases
{
    public class ValidaRutaArchivo : IValidaRutaArchivo
    {
        public StreamReader ArchivoExiste(string Ruta)
        {
            try
            {
                StreamReader sr = new StreamReader(Ruta);

                return sr;
            }
            catch (Exception)
            {
                throw new Exception("El archivo no fue encontrado");
            }
        }
    }
}
