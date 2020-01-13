using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Eventos_3.Interfaces
{
    public interface IImprimirMensajeEvento
    {
        void PrintMensajeEvento(string cEvento, string cEventoHaPasado, string cDiferenciaFechas);
    }
}
