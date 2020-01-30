using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ali Express";
            List<DatosPedidoDTO> datos = new Service().ObtenerPedidos();

            foreach (var lista in datos)
            {
                try
                {

                    #region "variables para calcular el costo"      
                    DateTime FechaHoy = DateTime.Now;
                    double dDistancia = lista.dDistancia;
                    string cTransporte = lista.cTransporte;
                    string cPaqueteria = lista.cPaqueteria;
                    DateTime dtFechaPedido = lista.dtFechaPedido;
                    #endregion

                    double HorasParaEntregarPaquete = new Service().obtenerTiempoEntregaxTransporte(cTransporte, dDistancia);
                    dtFechaPedido.AddDays(HorasParaEntregarPaquete);

                    string FechaEntrega = new Service().ObtenerDiferenciaFechas(dtFechaPedido, FechaHoy);
                    //Indica si el paquete a sido entregado
                    lista.PaqueteEntregado = (FechaEntrega.Split(',')[0] == "+") ? true : false;
                    //Indica el tiempo en el que se entregará el paquete o hace cuando fue entregado
                    lista.cTiempoEntrega = FechaEntrega.Split(',')[1];
                    //Indica cuanto costo el envio del paquete
                    lista.cCostoEnvio = new Service().ObtenerCostoPedido(dDistancia, cTransporte, cPaqueteria);

                }
                catch (Exception e)
                {
                    new Service().PrintError(e.Message);
                }
            }

            new Service().PrintResultado(datos);

            Console.ReadKey();
        }
    }
}
