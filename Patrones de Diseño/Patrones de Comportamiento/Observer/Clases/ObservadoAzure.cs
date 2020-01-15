using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer.Clases
{
    public class ObservadoAzure : IObservadoAzure
    {
        List<IObservador> lstObservadores = new List<IObservador>();

        public void addObsevador(IObservador observador)
        {
            this.lstObservadores.Add(observador);
        }

        public void DeleteObsevador(IObservador observador)
        {
            this.lstObservadores.Remove(observador);
        }

        public void Notificar(string _codigo, string _concepto)
        {
            Console.WriteLine("Azure notifica que esta leyendo el código");

            foreach (var observador in lstObservadores)
            {
                Thread.Sleep(2000);
                observador.Actualizar();
            }
            Thread.Sleep(2000);
            Console.WriteLine("\nCodigo subido: " + _codigo);
            Console.WriteLine("Concepto del Codigo subido: " + _concepto);
            Thread.Sleep(2000);
            cerrandoConsola();
        }

        public void SubirConjuntoCambio(string _codigo, string _concepto)
        {
            Notificar(_codigo, _concepto);
        }

        public void cerrandoConsola()
        {
            Console.WriteLine("Cerrando Consola . . .");
            Thread.Sleep(2000);
            Environment.Exit(-1);
        } 
    }
}
