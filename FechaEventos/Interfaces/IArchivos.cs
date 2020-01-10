using System.Collections.Generic;
using System.IO;
using TiempoEventos;

namespace FechaEventos.Interfaces
{
    public interface IArchivos
    {
        string ObtenerRutaArchivo();
        List<Evento> LeerArchivo(string _rutaArchivo);
        List<Evento> FomatearDatosArchivo(StreamReader _sr, List<Evento> _datos);
    }
}
