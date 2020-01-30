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
               if(lstPedidos.PaqueteEntregado) {
                    msgPaqueteEntregado(lstPedidos.cLugarOrigen, lstPedidos.cLugarDestino, lstPedidos.cTiempoEntrega, lstPedidos.cCostoEnvio, lstPedidos.cPaqueteria);
               }     
               else
               {
                    msgPaqueteEnCamino(lstPedidos.cLugarOrigen, lstPedidos.cLugarDestino, lstPedidos.cTiempoEntrega, lstPedidos.cCostoEnvio, lstPedidos.cPaqueteria);
               }
            }
        }

        private void msgPaqueteEntregado(string _cOrigen, string _cDestino, string _cTiempoEntrega, string _cCostoEnvio, string _cPaqueteria)
        {
            string cMensajeEntregado = $"Tu paquete salio de {_cOrigen} y llegó a {_cDestino} hace {_cTiempoEntrega}, tuvo un costo de ${_cCostoEnvio}. Cualquier Reclamación con {_cPaqueteria}";
            PrintColorMsg("VERDE", cMensajeEntregado);

        }

        private void msgPaqueteEnCamino(string _cOrigen, string _cDestino, string _cTiempoEntrega, string _cCostoEnvio, string _cPaqueteria)
        {
            string cMensajeNoEntregado = $"Tu paquete ha salido de {_cOrigen} y llegará a {_cDestino} dentro de {_cTiempoEntrega}, tendra un costo de ${_cCostoEnvio}. Cualquier Reclamación con {_cPaqueteria}";
            PrintColorMsg("AMARILLO", cMensajeNoEntregado);
        }

    }
}
