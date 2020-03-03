using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class MensajesBusiness
    {
        private PuenteMensajeColor msgColor;

        public void PrintColorMsg(string _color, string _cMensaje)
        {
            switch (_color)
            {
                case "ROJO":
                    msgColor = new PuenteMensajeColor(new MensajeRojo());
                    break;
                case "VERDE":
                    msgColor = new PuenteMensajeColor(new MensajeVerde());
                    break;
                case "AMARILLO":
                    msgColor = new PuenteMensajeColor(new MensajeAmarillo());
                    break;
                default:
                    msgColor = new PuenteMensajeColor(new MensajeGris());
                    break;
            }

            msgColor.Print(_cMensaje);
        }

        public void PrintMsgPedido(List<DatosPedidoDTO> _DatosPedido) 
        {
            foreach (var lstPedidos in _DatosPedido)
            {
                if (ValidarMensajeVacio(lstPedidos.cError))
                {
                    if (lstPedidos.PaqueteEntregado)
                    {
                        ImprimirMsgPaqueteEntregado(lstPedidos.cLugarOrigen, lstPedidos.cLugarDestino, lstPedidos.cTiempoEntrega, lstPedidos.cCostoEnvio, lstPedidos.cPaqueteria, new GeneradorArchivos());
                    }
                    else
                    {
                        ImprimirMsgPaqueteEnCamino(lstPedidos.cLugarOrigen, lstPedidos.cLugarDestino, lstPedidos.cTiempoEntrega, lstPedidos.cCostoEnvio, lstPedidos.cPaqueteria, new GeneradorArchivos());
                    }

                    PrintColorMsg("", lstPedidos.cEnvioBarato);
                }
                else
                {
                    PrintColorMsg("ROJO", lstPedidos.cError+"\n");
                }
            }
        }

        private void ImprimirMsgPaqueteEntregado(string _cOrigen, string _cDestino, string _cTiempoEntrega, double _cCostoEnvio, string _cPaqueteria, GeneradorArchivos GABusiness)
        {
            string cMensajeEntregado = $"Tu paquete salio de {_cOrigen} y llegó a {_cDestino} hace {_cTiempoEntrega}, tuvo un costo de ${_cCostoEnvio} pesos. Cualquier Reclamación con {_cPaqueteria}.";
            PrintColorMsg("VERDE", cMensajeEntregado);

            GABusiness.generarArchivo(_cPaqueteria, true, _cTiempoEntrega, cMensajeEntregado);
        }

        private void ImprimirMsgPaqueteEnCamino(string _cOrigen, string _cDestino, string _cTiempoEntrega, double _cCostoEnvio, string _cPaqueteria, GeneradorArchivos GABusiness)
        {
            string cMensajeNoEntregado = $"Tu paquete ha salido de {_cOrigen} y llegará a {_cDestino} dentro de {_cTiempoEntrega}, tendra un costo de ${_cCostoEnvio} pesos. Cualquier Reclamación con {_cPaqueteria}.";
            PrintColorMsg("AMARILLO", cMensajeNoEntregado);

            GABusiness.generarArchivo(_cPaqueteria, false, _cTiempoEntrega, cMensajeNoEntregado);
        }

        private bool ValidarMensajeVacio(string cMensaje)
        {
            if (cMensaje != null && cMensaje != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
