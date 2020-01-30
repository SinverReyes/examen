using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class PuenteMensajeColor
    {
        protected IMensaje color;

        public PuenteMensajeColor(IMensaje color)
        {
            this.color = color;
        }

        public virtual void Print(string _cMensaje) 
        {
            color.Print(_cMensaje);
        }
    }
}
