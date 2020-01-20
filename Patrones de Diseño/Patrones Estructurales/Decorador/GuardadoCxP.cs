
namespace Decorador
{
    public class GuardaCxP : GuardadoCxP
    {
        public override string RealizarOperacionExtra(int _iIdCxp, int _iImporte, int _iNaturaleza)
        {
            return $"<--- Guardando CxP {_iIdCxp} por la cantidad de ${_iImporte} pesos\n";
        }
    }
}
