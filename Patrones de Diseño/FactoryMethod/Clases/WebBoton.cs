using FactoryMethod.Interfaces;

namespace FactoryMethod.Clases
{
    public class WebBoton : IBoton
    {
        public string OnClick()
        {
            return "{Se creó el botón para Web}";
        }
    }
}
