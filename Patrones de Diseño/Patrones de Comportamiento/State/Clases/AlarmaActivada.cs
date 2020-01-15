using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Clases
{
    public class AlarmaActivada : IEstadoAlarma
    {
        //public IEstadoAlarma stateAlarma = null;
        private Alarma context;

        public void SetContext(Alarma _context)
        {
            context = _context;
        }

        public void Activar()
        {
            Console.WriteLine( "la alarma ya esta activada");
        }

        public void Desactivar()
        {
            AlarmaDesactivada abc = new AlarmaDesactivada();
            abc.SetContext(context);
            context.CambiarEstado(abc);          

            Console.WriteLine("alarma desactivada");
        }
    }
}
