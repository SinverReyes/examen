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

            try
            {
                using (StreamReader sr = new StreamReader(cRuta))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        lstdatos.Add(new DatosPedidoDTO
                        {
                            cLugarOrigen = line.Split(',')[0],
                            cLugarDestino = line.Split(',')[1],
                            dDistancia = double.Parse(line.Split(',')[2]),
                            cPaqueteria = line.Split(',')[3],
                            cTransporte = line.Split(',')[4],
                            dtFechaPedido = DateTime.Parse(line.Split(',')[5])
                        });
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
