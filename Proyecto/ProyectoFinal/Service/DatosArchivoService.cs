using System.Collections.Generic;

namespace ProyectoFinal
{
    public class DatosArchivoService
    {
        private DatosArchivoBusiness business;

        public DatosArchivoService(DatosArchivoBusiness _business)
        {
            business = _business;
        }

        public List<DatosPedidoDTO> ObtenerPedidos()
        {
            return business.ObtenerDatosArchivo();
        }
    }
}
