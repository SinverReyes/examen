using System;
using System.Threading;


namespace Decorador
{
    public class GuardadoHistorial : Decorador
    {

        public GuardadoHistorial(GuardadoCxP comp) : base(comp)
        {
        }

        public override string RealizarOperacionExtra(int _iIdCxp, int _iImporte, int _iNaturaleza)
        {
            Thread.Sleep(2000);
            return $"<--- Guardando historial de la CxP {_iIdCxp} por la cantidad de ${_iImporte} pesos\n{base.RealizarOperacionExtra(_iIdCxp, _iImporte, _iNaturaleza)}";
        }
    }
}
