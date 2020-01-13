using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Eventos_3.Interfaces
{
    public interface ICompararDosFechas
    {
        int CompararFechas(DateTime dtFechaBase, DateTime dtFechaComparaar, string cPeriodo);
    }
}
