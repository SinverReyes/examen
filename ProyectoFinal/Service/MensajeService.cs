using System.Collections.Generic;

namespace ProyectoFinal
{
    public class MensajeService
    {
        private MensajesBusiness msgBusiness;

        public MensajeService(MensajesBusiness _msgBusiness)
        {
            msgBusiness = _msgBusiness;
        }

        public void PrintResultado(List<DatosPedidoDTO> _DatosPedido)
        {
            msgBusiness.PrintMsgPedido(_DatosPedido);
        }

        public void PrintError(string _cMensaje)
        {
            msgBusiness.PrintColorMsg("ROJO", _cMensaje);
        }

        public void Print(string _cMensaje)
        {
            msgBusiness.PrintColorMsg("", _cMensaje);
        }
    }
}
