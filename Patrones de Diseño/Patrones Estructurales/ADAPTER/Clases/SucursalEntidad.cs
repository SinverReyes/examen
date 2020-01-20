using System.Collections.Generic;

namespace ADAPTER
{
    public class SucursalEntidad : IObtenerEntidadSucursal
    {
        public List<Sucursal> ObtenerSucursalEntidad()
        {
            List<Sucursal> lstSucursal = new List<Sucursal>();

            lstSucursal.Add(new Sucursal
            {
                IdSucursal = 1,
                cNombreSucursal = "Soriana",
                TotalVentas = 23000.50
            });

            return lstSucursal;
        }
    }
}
