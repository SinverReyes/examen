using Aplicacion_Eventos_3.Interfaces;
using System;

namespace Aplicacion_Eventos_3.Clases
{
    public class FechaBase : IFechaBase
    {
        public DateTime ObtenerFechaBase(string FechaEspecifica)
        {
            int iOption = 0;

            DateTime FechaResultante = new DateTime();

            if (FechaEspecifica != "")
            {
                iOption = 1;
            }

            switch (iOption)
            {
                case 0: FechaResultante = DateTime.Now; break;
                case 1: FechaResultante = DateTime.Parse(FechaEspecifica); break;
            }

            return FechaResultante;
        }
    }
}
