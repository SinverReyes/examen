
namespace CadenaResponsabilidad
{
    public class Subdirector : AbstractHandler
    {
        public override string Handle(double _dCosto)
        {
            if (_dCosto > 10000 && _dCosto <= 15000)
            {
                return $"El pago por la cantidad de ${_dCosto} pesos ha sido autorizado por el Subdirector";
            }
            else
            {
                return base.Handle(_dCosto);
            }
        }
    }
}
