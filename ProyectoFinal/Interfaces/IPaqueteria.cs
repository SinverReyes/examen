﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public interface IPaqueteria
    {
        string obtenerCostoxPaqueteria(string transporte, double _dDistancia);
    }
}