
namespace CadenaResponsabilidad
{
    public class Director : AbstractHandler
    {
        public override string Handle(double _dCosto)
        {
            if (_dCosto > 15000 && _dCosto <= 50000)
            {
                return $"El pago por la cantidad de ${_dCosto} pesos ha sido autorizado por el director";
            }
            else
            {
                return "La compra fue denegada";
            }
        }
    }
}
