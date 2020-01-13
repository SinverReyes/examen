using Aplicacion_Eventos_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Eventos_3.Clases
{
    public class EventoOcurrido : IEventoOcurrido
    {
        public string MensajeEventoOcurrito(int _valor)
        {
            string cResultado;

            if (_valor == 0)
            {
                cResultado = "es justo ahora";
            }
            else
            {
                cResultado = _valor < 0 ? "ocurrió hace" : "ocurrirá dentro de";
            }

            return cResultado;
        }
    }
}
