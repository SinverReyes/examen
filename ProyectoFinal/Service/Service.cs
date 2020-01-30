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

        public double obtenerTiempoEntregaxTransporte(string _cTransporte, double _dDistancia)
        {
            return new TransporteBusiness().obtenerTiempoEntregaxTransporte(_cTransporte, _dDistancia);
        }

        public List<DatosPedidoDTO> ObtenerPedidos()
        {
            return new DatosArchivoBusiness().ObtenerDatosArchivo();
        }

        public void PrintResultado(List<DatosPedidoDTO> _DatosPedido)
        {
            new MensajesBusiness().PrintMsgPedido(_DatosPedido);
        }

        public void PrintError(string _cMensaje)
        {
            new MensajesBusiness().PrintColorMsg("ROJO", _cMensaje);
        }

        public void Print(string _cMensaje)
        {
            new MensajesBusiness().PrintColorMsg("", _cMensaje);
        }

    }
}
