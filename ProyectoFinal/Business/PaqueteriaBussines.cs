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
            //try
            //{
                switch (cPaqueteriaMayuscula)
                {
                    case "DHL": paqueteria = new PuentePaqueteria(new PaqueteriaDHL()); break;
                    case "ESTAFETA": paqueteria = new PuentePaqueteria(new PaqueteriaEstafeta()); break;
                    case "FEDEX": paqueteria = new PuentePaqueteria(new PaqueteriaFedex()); break;
                    default: throw new Exception($"La paqueteria {_cPaqueteria} no se encuentra registrada en nuestra red de distribución");
                }

                cMensaje = paqueteria.Operation(_cTransporte, _dDistancia);

                return cMensaje;
            //}
            //catch (Exception e) 
            //{
            //    throw new Exception(new MensajesBusiness().PrintColorMsg("ROJO", e.Message));
            //}
        }
    }
}
