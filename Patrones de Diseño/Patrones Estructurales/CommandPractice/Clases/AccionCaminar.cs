
namespace CommandPractice
{
    public class AccionCaminar : ICommandAccion
    {
        private int PoderGuerrero;
        private string NombreGuerrero;
        private RecibeComandos receiver;

        public AccionCaminar(RecibeComandos _comandos, int _iPoder, string _cNombreGuerrero)
        {
            receiver = _comandos;
            PoderGuerrero = _iPoder;
            NombreGuerrero = _cNombreGuerrero;
        }

        public void Ejecutar()
        {
            PoderGuerrero *= 10;
            receiver.Caminar(PoderGuerrero, NombreGuerrero);
        }
    }
}
