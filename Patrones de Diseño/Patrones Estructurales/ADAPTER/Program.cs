using System;
using System.Collections.Generic;

namespace ADAPTER
{
    public class Program
    {
        static void Main(string[] args)
        {
            AdaptadorJsonEntidad adapterd = new AdaptadorJsonEntidad(new SucursalJson());

            List<Sucursal> lstSucursal = adapterd.ObtenerSucursalEntidad();

            Console.WriteLine("Sucursales");

            foreach (var lstFinal in lstSucursal)
            {
                Console.WriteLine("\n"+lstFinal.IdSucursal+"   "+ lstFinal.cNombreSucursal+ "   " +lstFinal.TotalVentas);
            }

            Console.ReadKey();

        }
    }
}
