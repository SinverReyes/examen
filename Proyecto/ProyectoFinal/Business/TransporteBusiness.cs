
namespace ProyectoFinal
{
    public class TransporteBusiness
    {
        private PuentePaqueteriaTransporte puenteTransporte;

        public PuentePaqueteriaTransporte ObtenerTransporte(string _cTransporte)
        {
            string cTransporteMayuscula = _cTransporte.ToUpper();

            switch (cTransporteMayuscula)
            {
                case "BARCO":
                    puenteTransporte = new PuentePaqueteriaTransporte(new ConcreteBarco());
                    break;
                case "TREN":
                    puenteTransporte = new PuentePaqueteriaTransporte(new ConcreteTren());
                    break;
                case "AVION":
                    puenteTransporte = new PuentePaqueteriaTransporte(new ConcreteAvion());
                    break;
            }

            return puenteTransporte;
        }

        public double ObtenerTiempoEntregaxTransporte(string _cTransporte, double _dDistancia)
        {
            puenteTransporte = ObtenerTransporte(_cTransporte);

            double dTiempoEntrega = puenteTransporte.ObtenerTiempoEntrega(_dDistancia);

            return dTiempoEntrega;
        }
    }
}
