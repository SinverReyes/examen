using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ClavePresupuestalLeaf : IComponente
    {
        private DatosCP DatosCuentaPresupuestal;

        public void SetCP(DatosCP _ClavePresupuestal)
        {
            DatosCuentaPresupuestal = _ClavePresupuestal;
        }

        public double ObtenerTotal()
        {
            return DatosCuentaPresupuestal.dTotalEnero +
                    DatosCuentaPresupuestal.dTotalFebrero +
                    DatosCuentaPresupuestal.dTotalMarzo +
                    DatosCuentaPresupuestal.dTotalAbril;
        }

        public int ObtenerId()
        {
            return DatosCuentaPresupuestal.id;
        }

    }
}
