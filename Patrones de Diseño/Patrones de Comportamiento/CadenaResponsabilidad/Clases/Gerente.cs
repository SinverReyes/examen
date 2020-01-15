
namespace CadenaResponsabilidad
{
    public class Gerente : AbstractHandler
    {
        public override string Handle(double _dCosto)
        {
            if (_dCosto > 5000 && _dCosto <= 10000)
            {
                return $"El pago por la cantidad de ${_dCosto} pesos ha sido autorizado por el Gerente";
            }
            else
            {
                return base.Handle(_dCosto);
            }
        }
    }
}
