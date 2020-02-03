
namespace ProyectoFinal
{
    public class PuenteMensajeColor
    {
        protected IMensaje color;

        public PuenteMensajeColor(IMensaje color)
        {
            this.color = color;
        }

        public virtual void Print(string _cMensaje) 
        {
            color.Print(_cMensaje);
        }
    }
}
