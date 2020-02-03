
namespace ProyectoFinal
{
    public class TransporteService
    {
        private TransporteBusiness Business;

        public double ObtenerTiempoEntregaxTransporte(string _cTransporte, double _dDistancia, string _cPaqueteria)
        {
            return Business.ObtenerTiempoEntregaxTransporte(_cTransporte, _dDistancia);
        }
    }
}
