using Aplicacion_Eventos_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Eventos_3.Clases
{
    public class FinalizarPrograma : IFinalizarPrograma
    {
        public void CerrarConsola()
        {
            Environment.Exit(-1);
        }
    }
}
