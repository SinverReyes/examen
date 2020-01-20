using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace ADAPTER
{
    public class AdaptadorJsonEntidad : IObtenerEntidadSucursal
    {
        private IObtenerJsonSucursal obtenerTotal;

        public AdaptadorJsonEntidad(IObtenerJsonSucursal _obtenerTotal)
        {
            obtenerTotal = _obtenerTotal;
        }

        public List<Sucursal> ObtenerSucursalEntidad()
        {
            List<Sucursal> lstSucursal = new List<Sucursal>();

            string SucursalJson = obtenerTotal.ObtenerSucursalJson();

            JObject lstTemp = JObject.Parse(SucursalJson);

            IList<JToken> result = lstTemp["ResponseData"]["Data"].Children().ToList();

            foreach (JToken resultado in result)
            {
                Sucursal SucursalFinal = JsonConvert.DeserializeObject<Sucursal>(resultado.ToString());
                lstSucursal.Add(SucursalFinal);
            }

            return lstSucursal;
        }
    }
}
