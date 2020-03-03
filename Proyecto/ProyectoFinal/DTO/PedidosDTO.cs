using System.Collections.Generic;

namespace ProyectoFinal
{
    public class DatosPedidosJson
    {
        public string Procedencia { get; set; }
        public string Destino { get; set; }
        public int Dist_KM { get; set; }
        public string Empresa { get; set; }
        public string MedioTrans { get; set; }
        public string FechaPedido { get; set; }
    }

    public class PedidosDTO
    {
        public List<DatosPedidosJson> lstPedidos { get; set; }
    }
}

