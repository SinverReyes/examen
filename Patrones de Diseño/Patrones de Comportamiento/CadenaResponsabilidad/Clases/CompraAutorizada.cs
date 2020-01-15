using System;

namespace CadenaResponsabilidad
{
    public class CompraAutorizada
    {

        public void main(AbstractHandler handler, double _dCosto, string _cConcepto)
        {
            var result = handler.Handle(_dCosto);

            Console.Write("\n" + _cConcepto + "\n" + result);
        }
    }
}
