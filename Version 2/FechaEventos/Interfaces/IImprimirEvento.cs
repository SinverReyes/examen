﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaEventos.Interfaces
{
    public interface IImprimirEvento
    {
        void PrintMensajeEvento(string _cNombreEvento, string _cYaOcurrio, string _cPeriodo);
    }
}
