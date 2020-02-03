
namespace ProyectoFinal
{
    public class PuentePaqueteria
    {
        protected IPaqueteria Paqueteria;

        public PuentePaqueteria(IPaqueteria _paqueteria)
        {
            Paqueteria = _paqueteria;
        }
        public virtual double ObtenerCostoPedido(string _transporte, double _dDistancia)
        {
            return Paqueteria.ObtenerCostoPedido(_transporte, _dDistancia);
        }

        public virtual double ObtenerTiempoEntrega(string _transporte, double _dDistancia)
        {
            return Paqueteria.ObtenerTiempoEntrega( _dDistancia);
        }
    }
}
