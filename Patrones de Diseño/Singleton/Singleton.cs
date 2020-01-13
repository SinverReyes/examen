
namespace Singleton
{
    public class Singleton
    {
        private Singleton() { }

        //debe tener el mismo nombre que la clase
        private static Singleton _instance;

        //constructor
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public void AquiVaElCodigoDeLaClase()
        {
        }
    }
}
