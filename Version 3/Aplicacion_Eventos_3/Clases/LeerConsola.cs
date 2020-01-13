using Aplicacion_Eventos_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Eventos_3.Clases
{
    public class LeerConsola : ILeerConsola
    {
        public string ReadConsola()
        {
            string Lectura = Console.ReadLine();

            return Lectura;
        }
    }
}
