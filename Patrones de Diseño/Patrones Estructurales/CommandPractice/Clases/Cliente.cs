using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPractice
{
    public class Cliente
    {
        Invocador invoker = new Invocador();
        RecibeComandos receiver = new RecibeComandos();

        public void RealizarAccion(int _iGuerrero, int _iAccion, string _cNombre)
        {
            switch (_iAccion)
            {
                case 1: invoker.SetCaminar(new AccionCaminar(receiver, _iGuerrero, _cNombre));  break;
                case 2: invoker.SetSaltar(new AccionSaltar(receiver, _iGuerrero, _cNombre));  break;
                case 3: invoker.SetGolpear(new AccionGolpear(receiver, _iGuerrero, _cNombre));  break;
                case 4: invoker.SetDispararPistola(new AccionDispararPistola(receiver, _iGuerrero, _cNombre));  break;
                case 5: invoker.SetLanzarGranada(new AccionLanzarGranada(receiver, _iGuerrero, _cNombre));  break;
                case 6: invoker.SetDispararRiflePlasma(new AccionDispararRiflePlasma(receiver, _iGuerrero, _cNombre));  break;
            }

            invoker.EjecutarAccion();
        }
    }
}
