

namespace ProyectoFinal
{
    public class PaqueteriaService
    {
        private PaqueteriaBusiness bussines;

        public PaqueteriaService(PaqueteriaBusiness _bussines)
        {
            bussines = _bussines;
        }

        public string ObtenerCostoMasBarato(double _dDistancia, string _cTransporte, string _cPaqueteria, double dCostoAnterior)
        {
            return bussines.ObtenerCostoMasBarato(_dDistancia, _cTransporte, _cPaqueteria, dCostoAnterior);
        }

        public PuentePaqueteria ElegirPaqueteria(string _cPaqueteria)
        {
            return bussines.ElegirPaqueteria(_cPaqueteria);
        }
    }
}
