using System;

namespace ProyectoFinal
{
    public class DatosPedidoDTO
    {
        //datos del pedido
        public string cLugarOrigen { get; set; }
        public string cLugarDestino { get; set; }
        public string cPaqueteria { get; set; }
        public string cTransporte { get; set; }
        public double dDistancia { get; set; }
        public DateTime dtFechaPedido { get; set; }

        //Valores que se calculan con los datos del pedido
        public double cCostoEnvio { get; set; }
        public string cTiempoEntrega { get; set; }
        public bool PaqueteEntregado { get; set; }

        //Indica si se produjo un error con este pedido 
        public string cError { get; set; }

        //Indica si existe una paqueteria con el mismo servicio pero mas barato
        public string cEnvioBarato { get; set; }
    }
}
