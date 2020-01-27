using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinal
{
    public class DatosArchivoBusiness
    {
        public List<DatosPedidoDTO> ObtenerDatosArchivo()
        {
            string cRuta = @"C:\Users\sinver.reyes\source\repos\ProyectoFinal\BaseDatos.txt";
            List<DatosPedidoDTO> lstdatos = new List<DatosPedidoDTO>();
            DatosPedidoDTO datos = new DatosPedidoDTO();

            try
            {
                using (StreamReader sr = new StreamReader(cRuta))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        datos.cLugarOrigen = line.Split(',')[0];
                        datos.cLugarDestino = line.Split(',')[1];
                        datos.dDistancia = double.Parse(line.Split(',')[2]);
                        datos.cPaqueteria = line.Split(',')[3];
                        datos.cTransporte = line.Split(',')[4];
                        datos.dtFechaPedido = DateTime.Parse(line.Split(',')[5]);
                        lstdatos.Add(datos);
                    }

                    return lstdatos;
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se encontró el archivo");
            }

        }
    }
}
