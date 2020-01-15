using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Clases
{
    public class Alarma
    {
        private IEstadoAlarma Estado = null;

        public Alarma(IEstadoAlarma _EstadoInicial)
        {
            Estado = _EstadoInicial;
            
        }

        public void Activar()
        {
            this.Estado.Activar();
        }

        public void Desactivar()
        {
            this.Estado.Desactivar();
        }

        public void CambiarEstado(IEstadoAlarma _Estado)
        {
            //Console.WriteLine($"Cambiando estado de la alarma a {_Estado.GetType().Name}.");
            this.Estado = _Estado;      
            
        }
    }
}
