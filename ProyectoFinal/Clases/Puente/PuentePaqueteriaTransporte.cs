using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class PuentePaqueteriaTransporte
    {
        protected ITransporte Transporte;

        public PuentePaqueteriaTransporte(ITransporte _Transporte)
        {
            Transporte = _Transporte;
        }

        public virtual string ObtenerCostoEnvio(double _MargenUtilidad, double _dDistancia)
        {
            return Transporte.ObtenerCostoEnvio(_MargenUtilidad, _dDistancia);
        }

        public virtual double obtenerTiempoEntrega(double _dDistancia)
        {
            return Transporte.obtenerTiempoEntrega(_dDistancia);
        }
    }
}
