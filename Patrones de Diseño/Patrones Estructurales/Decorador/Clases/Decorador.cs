
namespace Decorador
{
    public abstract class Decorador : GuardadoCxP
    {
        protected GuardadoCxP GuardadoCxP;

        protected Decorador(GuardadoCxP _guardarCxP)
        {
            GuardadoCxP = _guardarCxP;
        }

        public void SetComponent(GuardadoCxP component)
        {
            GuardadoCxP = component;
        }

        public override string RealizarOperacionExtra(int _iIdCxp, int _iImporte, int _iNaturaleza)
        {
            if (GuardadoCxP != null)
            {
                return GuardadoCxP.RealizarOperacionExtra(_iIdCxp, _iImporte, _iNaturaleza);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
