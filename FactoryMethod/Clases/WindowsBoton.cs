using FactoryMethod.Interfaces;

namespace FactoryMethod.Clases
{
    public class WindowsBoton : IBoton
    {
        public string OnClick()
        {
            return "{Se creó el botón para Windows}";
        }
    }
}
