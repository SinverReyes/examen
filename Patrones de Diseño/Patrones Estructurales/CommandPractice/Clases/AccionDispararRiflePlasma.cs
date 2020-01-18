
namespace CommandPractice
{
    public class AccionDispararRiflePlasma : ICommandAccion
    {
        private int PoderGuerrero;
        private string NombreGuerrero;
        private RecibeComandos receiver;

        public AccionDispararRiflePlasma(RecibeComandos _comandos, int _iPoder, string _cNombreGuerrero)
        {
            receiver = _comandos;
            PoderGuerrero = _iPoder;
            NombreGuerrero = _cNombreGuerrero;
        }

        public void Ejecutar()
        {
            PoderGuerrero *= 10;
            receiver.DispararRiflePlasma(PoderGuerrero, NombreGuerrero);
        }
    }
}
