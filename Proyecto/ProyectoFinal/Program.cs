using System;
using System.Linq;
using System.Collections.Generic;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ali Express";

            VerificarEntregaPedido();
            
            Console.ReadKey();
        }

        public static void VerificarEntregaPedido()
        {
            PaqueteriaService srvPaqueteria = new PaqueteriaService(new PaqueteriaBusiness());
            FechasService srvFechas = new FechasService(new DiferenciaFechasBusiness());
            MensajeService msgSrv = new MensajeService(new MensajesBusiness());
            DatosArchivoService srvArchivo = new DatosArchivoService(new DatosArchivoBusiness());
            List<DatosPedidoDTO> datos = new List<DatosPedidoDTO>();
            List<PedidosDTO> datos2 = new List<PedidosDTO>(); 

            try
            {

                //Obtiene la información del archivo
                datos = srvArchivo.ObtenerPedidos();
                //datos2 = srvArchivo.ObtenerDatosJSon(datos2);



                //Recorre la lista de pedidos
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

                        //Se obtiene la paqueteria
                        var Paqueteria = srvPaqueteria.ElegirPaqueteria(cPaqueteria);

                        //Obtiene el costo total del envio
                        lista.cCostoEnvio = Paqueteria.ObtenerCostoPedido(cTransporte, dDistancia);

                        //Obtiene el tiempo que tardará el transporte en entregar el pedido
                        var HorasParaEntregarPedidoxTransporte = Paqueteria.ObtenerTiempoEntrega(cTransporte, dDistancia);
                        dtFechaPedido.AddHours(HorasParaEntregarPedidoxTransporte);

                        var TiempoRestanteEntregaTemp = srvFechas.ObtenerDiferenciaFechas(dtFechaPedido, FechaHoy);
                        //Indica si el paquete a sido entregado
                        lista.PaqueteEntregado = (TiempoRestanteEntregaTemp.Split(',')[0] == "-") ? true : false;
                        //Indica el tiempo en el que se entregará el paquete o hace cuando fue entregado
                        lista.cTiempoEntrega = TiempoRestanteEntregaTemp.Split(',')[1];
                        //Verifica si el envio hubiese costado menos en alguna otra paqueteria 
                        lista.cEnvioBarato = srvPaqueteria.ObtenerCostoMasBarato(dDistancia, cTransporte, cPaqueteria, lista.cCostoEnvio);
                    }
                    catch (Exception e)
                    {
                        lista.cError = e.Message;
                    }
                }

                msgSrv.PrintResultado(datos);
            }
            catch (Exception e)
            {
                msgSrv.PrintError(e.Message);
            }
        }

        public static void TipoArchivo(string opt)
        {
            switch (opt)
            {
                case "cvc": break;
                case "json": break;

            }
        }

        private static void otro()
        {
            List<PaquetriasTransporteDTO> lsttransporte = new List<PaquetriasTransporteDTO>();
            List<MediosTransporte> ls = new List<MediosTransporte>();
            DatosArchivoService srvTransporte = new DatosArchivoService(new DatosArchivoBusiness());

            lsttransporte = srvTransporte.ObtenerDatosPaqueteriaJson(lsttransporte);

            foreach (var x in lsttransporte.Select(x=> x.Paqueterias))
            {
                var uno = x.Select(s=> s.MargenUtilidad).First();
            }
        }
    }
}
