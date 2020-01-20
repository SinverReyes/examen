using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class GuardarCxPService
    {
        public void GuardadoCxP(int _iIdCxP, int _iImporte, int _iNaturaleza)
        {
            var simple = new GuardaCxP();

            EnvioCorreo decorator1 = new EnvioCorreo(simple);
            GuardadoHistorial decorator2 = new GuardadoHistorial(simple);
            EnvioCorreo decorator3 = new EnvioCorreo(decorator2);

            Console.WriteLine(decorator1.RealizarOperacionExtra(_iIdCxP, _iImporte, _iNaturaleza));//guarda y envia correo
            Console.WriteLine(decorator2.RealizarOperacionExtra(_iIdCxP, _iImporte, _iNaturaleza));//guarda cxp y genera historial
            Console.WriteLine(decorator3.RealizarOperacionExtra(_iIdCxP, _iImporte, _iNaturaleza));//guarda cxp, genera historial y envia correo
        }
    }
}
