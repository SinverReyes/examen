﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class MensajeRojo : IMensaje
    {
        public void Print(string cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(cMensaje);
        }
    }
}