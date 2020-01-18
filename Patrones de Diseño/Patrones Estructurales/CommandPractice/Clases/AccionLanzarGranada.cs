
namespace CommandPractice
{
    public class AccionLanzarGranada : ICommandAccion
    {
        private int PoderGuerrero;
        private string NombreGuerrero;
        private RecibeComandos receiver;

        public AccionLanzarGranada(RecibeComandos _comandos, int _iPoder, string _cNombreGuerrero)
        {
            receiver = _comandos;
            PoderGuerrero = _iPoder;
            NombreGuerrero = _cNombreGuerrero;
        }

        public void Ejecutar()
        {
            PoderGuerrero *= 10;
            receiver.LanzarGranada(PoderGuerrero, NombreGuerrero);
        }
    }
}
