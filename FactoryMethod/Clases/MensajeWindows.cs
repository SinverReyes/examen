using FactoryMethod.Interfaces;

namespace FactoryMethod.Clases
{
    public class MensajeWindows : Messaje
    {
        public override IBoton FactoryMethod()
        {
            return new WindowsBoton();
        }
    }
}
