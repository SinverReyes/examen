using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal
{
    public class DatosArchivoBusiness
    {
        public List<DatosPedidoDTO> ObtenerDatosArchivo()
        {
            string cRuta = @"..\..\BaseDatos.txt";
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
                            cLugarOrigen = line.Split(',')[0].Trim(),
                            cLugarDestino = line.Split(',')[1].Trim(),
                            dDistancia = double.Parse(line.Split(',')[2]),
                            cPaqueteria = line.Split(',')[3].Trim(),
                            cTransporte = line.Split(',')[4].Trim(),
                            dtFechaPedido = DateTime.Parse(line.Split(',')[5])
                        });
                    }

                    return lstdatos;
                }
            }
            catch (Exception)
            {
                throw new Exception("No se encontró el archivo");
            }
        }
    }
}
