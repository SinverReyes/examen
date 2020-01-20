namespace ADAPTER
{
    public class SucursalJson : IObtenerJsonSucursal
    {
        public string ObtenerSucursalJson()
        {
            string json = @"{
                            'ResponseData': {
                            'Data': [
                                     {
                                    'IdSucursal':'1',
                                    'cNombreSucursal':'Soriana',
                                    'TotalVentas':'12000',
                                     },
                                    ],
                                },
                            }";

            return json;
        }
    }
}
