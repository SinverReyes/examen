
namespace CommandPractice
{
    public class AccionDispararPistola : ICommandAccion
    {
        private int PoderGuerrero;
        private string NombreGuerrero;
        private RecibeComandos receiver;

        public AccionDispararPistola(RecibeComandos _comandos, int _iPoder, string _cNombreGuerrero)
        {
            receiver = _comandos;
            PoderGuerrero = _iPoder;
            NombreGuerrero = _cNombreGuerrero;
        }

        public void Ejecutar()
        {
            PoderGuerrero *= 10;
            receiver.DispararPistola(PoderGuerrero, NombreGuerrero);
        }
    }
}
