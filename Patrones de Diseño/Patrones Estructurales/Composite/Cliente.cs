using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Cliente
    {
        public void ObtenerTotales()
        {
            UAComposite UA = new UAComposite("1");
            DatosCP cp1 = new DatosCP(1, 123, 100, 456, 67);
            DatosCP cp2 = new DatosCP(2, 34, 123, 546, 0);
            DatosCP cp3 = new DatosCP(3, 435, 78, 34, 756);
            ClavePresupuestalLeaf ClavePresupuestal1 = new ClavePresupuestalLeaf();
            ClavePresupuestal1.SetCP(cp1);
            ClavePresupuestalLeaf clavePresupuestal2 = new ClavePresupuestalLeaf();
            clavePresupuestal2.SetCP(cp2);
            ClavePresupuestalLeaf clavePresupuestal3 = new ClavePresupuestalLeaf();
            clavePresupuestal3.SetCP(cp3);
            UA.AgregarComposite(ClavePresupuestal1);
            UA.AgregarComposite(clavePresupuestal2);
            UA.AgregarComposite(clavePresupuestal3);

            UAComposite ua2 = new UAComposite("2");
            DatosCP cp4 = new DatosCP(1, 234, 10056, 15600, 10780);
            DatosCP cp5 = new DatosCP(2, 200, 89, 100, 10056);
            DatosCP cp6 = new DatosCP(3, 0, 67, 100, 456);
            ClavePresupuestalLeaf clavePresupuestal4 = new ClavePresupuestalLeaf();
            clavePresupuestal4.SetCP(cp4);
            ClavePresupuestalLeaf clavePresupuestal5 = new ClavePresupuestalLeaf();
            clavePresupuestal5.SetCP(cp5);
            ClavePresupuestalLeaf clavePresupuestal6 = new ClavePresupuestalLeaf();
            clavePresupuestal6.SetCP(cp6);
            ua2.AgregarComposite(clavePresupuestal4);
            ua2.AgregarComposite(clavePresupuestal5);
            ua2.AgregarComposite(clavePresupuestal6);

            double resultado = UA.ObtenerTotal();
            double resultado2 = ua2.ObtenerTotal();

            Console.WriteLine("Total: " + (resultado + resultado2));
        }
    }
}
