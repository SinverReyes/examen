using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class PuentePaqueteria
    {
        protected IPaqueteria Paqueteria;

        public PuentePaqueteria(IPaqueteria _paqueteria)
        {
            Paqueteria = _paqueteria;
        }
        public virtual string Operation(string _transporte, double _dDistancia)
        {
            return Paqueteria.obtenerCostoxPaqueteria(_transporte, _dDistancia);
        }
    }
}
