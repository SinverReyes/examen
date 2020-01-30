using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class DatosPedidoDTO
    {
        public string cLugarOrigen { set; get; }
        public string cLugarDestino { set; get; }
        public string cPaqueteria { set; get; }
        public string cTransporte { set; get; }
        public double dDistancia { set; get; }
        public DateTime dtFechaPedido { set; get; }

        public string cCostoEnvio { set; get; }
        public string cTiempoEntrega { set; get; }
        public bool PaqueteEntregado { set; get; }
    }
}
