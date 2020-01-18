using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPractice
{
    public class Invocador
    {
        private ICommandAccion Caminar;
        private ICommandAccion Saltar;
        private ICommandAccion Golpear;
        private ICommandAccion DispararPistola;
        private ICommandAccion LanzarGranada;
        private ICommandAccion DispararRiflePlasma;

        public void SetCaminar(ICommandAccion command)
        {
            Caminar = command;
        }

        public void SetSaltar(ICommandAccion command)
        {
            Saltar = command;
        }

        public void SetGolpear(ICommandAccion command)
        {
            Golpear = command;
        }

        public void SetDispararPistola(ICommandAccion command)
        {
            DispararPistola = command;
        }

        public void SetLanzarGranada(ICommandAccion command)
        {
            LanzarGranada = command;
        }

        public void SetDispararRiflePlasma(ICommandAccion command)
        {
            DispararRiflePlasma = command;
        }

        public void EjecutarAccion()
        {
            if (Caminar is ICommandAccion)
            {
                Caminar.Ejecutar();
            }

            if (Golpear is ICommandAccion)
            {
                Golpear.Ejecutar();
            }

            if (Saltar is ICommandAccion)
            {
                Saltar.Ejecutar();
            }

            if (DispararPistola is ICommandAccion)
            {
                DispararPistola.Ejecutar();
            }

            if (LanzarGranada is ICommandAccion)
            {
                LanzarGranada.Ejecutar();
            }

            if (DispararRiflePlasma is ICommandAccion)
            {
                DispararRiflePlasma.Ejecutar();
            }
        }

    }
}
