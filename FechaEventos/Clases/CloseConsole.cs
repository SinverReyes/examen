using FechaEventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaEventos.Clases
{
    public class CloseConsole : ICerrarConsola
    {
        public void CerrarConsola()
        {
            Environment.Exit(-1);
        }
    }
}
