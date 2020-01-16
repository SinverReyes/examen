using System;

namespace ADAPTER
{
    public class Program
    {
        static void Main(string[] args)
        {
            AdaptadorStringDouble adapter = new AdaptadorStringDouble(new TotalString());

            Console.WriteLine(adapter.ObtenerValorTotalDouble());

            Console.ReadKey();

        }
    }
}
