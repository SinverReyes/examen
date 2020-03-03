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

        public List<PedidosDTO> ObtenerDatosJSon(List<PedidosDTO> lstDatos)
        {
            return business.ObtenerDatosJSon(lstDatos);
        }

        public List<PaquetriasTransporteDTO> ObtenerDatosPaqueteriaJson(List<PaquetriasTransporteDTO> lstDatos)
        {
            return business.ObtenerDatosPaqueteriaJson(lstDatos);
        }
    }
}
