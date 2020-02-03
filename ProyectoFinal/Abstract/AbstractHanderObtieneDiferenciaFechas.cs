
namespace ProyectoFinal
{
    public abstract class AbstractHanderObtieneDiferenciaFechas : IObtieneDiferenciaFechas
    {
        private IObtieneDiferenciaFechas nextHandler;

        public IObtieneDiferenciaFechas NextNivel(IObtieneDiferenciaFechas _Handler)
        {
            nextHandler = _Handler;

            return nextHandler;
        }

        public virtual string ObtenerDiferenciaFechas()
        {
            if (nextHandler != null)
            {
                return nextHandler.ObtenerDiferenciaFechas();
            }
            else
            {
                return null;
            }
        }
    }
}
