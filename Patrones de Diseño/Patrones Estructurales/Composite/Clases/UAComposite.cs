using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class UAComposite : IComponente
    {
        protected List<IComponente> lstEstructura;
        string cIdCP;

        public UAComposite(string _cIdCP)
        {
            lstEstructura = new List<IComponente>();
            cIdCP = _cIdCP;
        }

        public double ObtenerTotal()
        {
            double dTotalUA = 0;
            double result = 0;
            int iId = 0;
            foreach (IComponente component in lstEstructura)
            {
                result += component.ObtenerTotal();
                dTotalUA += result;
                iId = component.ObtenerId();

                Console.WriteLine("UA " + cIdCP + "." + iId + " : " + result);
                result = 0;
            }

            Console.WriteLine("UA " + cIdCP + ":" + dTotalUA + "\n");

            return dTotalUA;
        }

        public int ObtenerId()
        {
            return 0; //  DatosCuentaPresupuestal.id;
        }


        public void AgregarComposite(IComponente _Componente)
        {
            lstEstructura.Add(_Componente);
        }

        public void EliminarComposite(IComponente _Componente)
        {
            lstEstructura.Remove(_Componente);
        }
    }
}
