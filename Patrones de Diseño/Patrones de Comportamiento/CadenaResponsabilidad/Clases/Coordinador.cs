
namespace CadenaResponsabilidad
{
    public class Coordinador : AbstractHandler
    {
        public override string Handle(double _dCosto)
        {
            if (_dCosto > 0 && _dCosto <= 5000)
            {
                return $"El pago por la cantidad de ${_dCosto} pesos ha sido autorizado por el Coordinador";
            }
            else
            {
                return base.Handle(_dCosto);
            }
        }
    }
}
