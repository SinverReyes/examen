using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class PaqueteriaBussines
    {
        private PuentePaqueteria paqueteria;

        public string ElegirPaqueteria(string _cPaqueteria, string _cTransporte, double _dDistancia)
        {
            string cMensaje;
            string cPaqueteriaMayuscula = _cPaqueteria.ToUpper();

            switch (cPaqueteriaMayuscula)
            {
                case "DHL": paqueteria = new PuentePaqueteria(new PaqueteriaDHL()); break;
                case "ESTAFETA": paqueteria = new PuentePaqueteria(new PaqueteriaEstafeta()); break;
                case "FEDEX": paqueteria = new PuentePaqueteria(new PaqueteriaFedex()); break;
                default: throw new Exception("No contamos con la paqueteria " + _cPaqueteria);
            }

            cMensaje = paqueteria.Operation(_cTransporte, _dDistancia);

            return cMensaje;
        }
    }
}
