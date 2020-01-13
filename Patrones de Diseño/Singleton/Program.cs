using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton funcionó, ambas variables contienen la misma instancia.");
            }
            else
            {
                Console.WriteLine("Singleton falló, las variables contienen diferentes instancias.");
            }

            Console.ReadKey();
        }
    }
}
