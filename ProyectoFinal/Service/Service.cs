using System;
using System.Collections.Generic;

namespace ProyectoFinal
{
    public class Service
    {
        public string ObtenerDiferenciaFechas(DateTime _dtFechaEntrega, DateTime _dtFechaActual)
        {
            return new DiferenciaFechasBusiness().obtenerDiferenciaFechas(_dtFechaEntrega, _dtFechaActual);
        }

        public string ObtenerCostoPedido(double _dDistancia, string _cTransporte, string _cPaqueteria)
        {
            return new PaqueteriaBussines().ElegirPaqueteria(_cPaqueteria, _cTransporte, _dDistancia);
        }

        public List<DatosPedidoDTO> ObtenerPedidos()
        {
            return new DatosArchivoBusiness().ObtenerDatosArchivo();
        }

        public List<ExpresionesDTO> PrintResultado(List<ExpresionesDTO> Expresiones)
        {
            return Expresiones;
        }
    }
}
