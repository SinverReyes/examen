using FactoryMethod.Interfaces;

namespace FactoryMethod.Clases
{
    public abstract class Messaje
    {
        public abstract IBoton FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Messaje: Presione el botón aceptar para continuar "
                + product.OnClick();

            return result;
        }
    }
}
