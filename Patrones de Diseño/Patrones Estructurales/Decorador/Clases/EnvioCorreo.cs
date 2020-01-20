using System.Threading;

namespace Decorador
{
    public class EnvioCorreo : Decorador
    {

        public EnvioCorreo(GuardadoCxP comp) : base(comp)
        {
        }

        public override string RealizarOperacionExtra(int _iIdCxp, int _iImporte, int _iNaturaleza)
        {
            Thread.Sleep(2000);
            return $"<--- Envio de Correo: La cxp {_iIdCxp} por la cantidad de ${_iImporte} pesos ha sido creada\n{base.RealizarOperacionExtra(_iIdCxp, _iImporte, _iNaturaleza)}\n";
        }
    }
}
