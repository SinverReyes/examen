using System;
using Observer.Clases;

namespace Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var subject = new ObservadoAzure();

            var observerA = new Compilar();
            subject.addObsevador(observerA);

            var observerB = new PruebasUnitarias();
            subject.addObsevador(observerB);

            var observerC = new Versionar();
            subject.addObsevador(observerC);

            var observerD = new EnvioCorreo();
            subject.addObsevador(observerD);

            string codigo = "Console.WriteLine('Este es el código subido')";
            string Concepto = "Código para imprimir en consola";

            subject.SubirConjuntoCambio(codigo, Concepto);

            Console.ReadKey();
        }
    }
}
