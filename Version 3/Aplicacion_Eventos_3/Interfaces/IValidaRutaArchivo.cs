using System.IO;

namespace Aplicacion_Eventos_3.Interfaces
{
    public interface IValidaRutaArchivo
    {
        StreamReader ArchivoExiste(string Ruta);
    }
}
