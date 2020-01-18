
using System;

namespace CommandPractice
{
    public class RecibeComandos
    {
        public void Caminar(int _iPoder, string _cNombre)
        {
            Console.WriteLine( "El Guerrero "+_cNombre+" camina a una velocidad de "+_iPoder+" pasos por minuto");
        }

        public void Saltar(int _iPoder, string _cNombre)
        {
            Console.WriteLine("El Guerrero " + _cNombre + " salta " + _iPoder + " a metros de altura");
        }
        public void Golpear(int _iPoder, string _cNombre)
        {
            Console.WriteLine("El Guerrero " + _cNombre + " golpea con un de poder " + _iPoder + " newtonws");
        }
        public void DispararPistola(int _iPoder, string _cNombre)
        {
            Console.WriteLine("El Guerrero " + _cNombre + " dispara con una pistola " + _iPoder + " balas por minuto");
        }

        public void LanzarGranada(int _iPoder, string _cNombre)
        {
            Console.WriteLine("El Guerrero " + _cNombre + " lanza una granada desde " + _iPoder + " metros de distancia");
        }

        public void DispararRiflePlasma(int _iPoder, string _cNombre)
        {
            Console.WriteLine("El Guerrero " + _cNombre + " dispara con la pistola de plasma " + _iPoder + " balas por minuto");
        }
    }
}
