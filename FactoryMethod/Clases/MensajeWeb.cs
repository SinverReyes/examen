using FactoryMethod.Interfaces;

namespace FactoryMethod.Clases
{
    public class MensajeWeb : Messaje
    {
        public override IBoton FactoryMethod()
        {
            return new WebBoton();
        }
    }
}
