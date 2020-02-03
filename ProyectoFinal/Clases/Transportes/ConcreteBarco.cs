
namespace ProyectoFinal
{
    public class ConcreteBarco : ITransporte
    {
        private int iCostoEnvioxKm = 1;
        private int iVelocidadEntrega = 46;

        public double ObtenerCostoEnvio(double _MargenUtilidad, double _dDistancia)
        {
            double dCostoTotal = (iCostoEnvioxKm * _dDistancia * (1 + (_MargenUtilidad / 100)));

            return dCostoTotal;
        }

        public double ObtenerTiempoEntrega(double _dDistancia)
        {
            double dHoras = (_dDistancia / iVelocidadEntrega);

            return dHoras;
        }
    }
}
