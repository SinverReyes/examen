using System;
using System.Collections.Generic;
using State.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Clases
{
    public class AlarmaDesactivada : IEstadoAlarma
    {
        public IEstadoAlarma stateAlarma = null;
        private Alarma context;

        public void SetContext(Alarma _context)
        {
            context = _context;
        }

        public void Activar()
        {
            AlarmaActivada abc = new AlarmaActivada();
            abc.SetContext(context);
            context.CambiarEstado(abc);

            Console.WriteLine("alarma activada");
        }

        public void Desactivar()
        {
            Console.WriteLine("la alarma ya esta desactivada");
        }

    }
}
