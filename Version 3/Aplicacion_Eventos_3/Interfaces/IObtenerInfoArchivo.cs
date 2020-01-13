using Aplicacion_Eventos_3.DTO;
using System.Collections.Generic;
using System.IO;

namespace Aplicacion_Eventos_3.Interfaces
{
    public interface IObtenerInfoArchivo
    {
        List<Eventos> ObtenerDatosArchivoTxt(StreamReader archivo);
    }
}
