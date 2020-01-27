using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Program
    {
        static readonly string cMensaje = "Tu paquete {0} de {1} y {2} a {3} {4} y {5} un costo de ${6} pesos. (Cualquier reclamo con {7})";
        static void Main(string[] args)
        {
            Console.Title = "Ali Express";

            List<DatosPedidoDTO> datos = new Service().ObtenerPedidos();
            //List<ExpresionesDTO> Expresiones;

            foreach (var lista in datos)
            {
                #region "variables para calcular el costo"                
                double dDistancia = lista.dDistancia;
                string cTransporte = lista.cTransporte;
                string cPaqueteria = lista.cPaqueteria;
                DateTime dtFechaPedido = lista.dtFechaPedido;
                #endregion

                DateTime dtFechaEntrega = DateTime.Parse("25/12/2019");
                string DiferenciaFechas = new Service().ObtenerDiferenciaFechas(dtFechaEntrega, DateTime.Now);
                string costoPaqueteria = new Service().ObtenerCostoPedido(dDistancia, cTransporte, cPaqueteria);

                Console.WriteLine(cMensaje, "salio", "NewYork", "llegará", "Yucatán", DiferenciaFechas, "tendra", costoPaqueteria, "DHL");

            }

            //new Service().PrintResultado(Expresiones);


            Console.ReadKey();
        }
    }
}
