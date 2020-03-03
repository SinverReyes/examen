using System;
using System.Collections.Generic;

namespace ProyectoFinal
{
    public class MediosTransporte
    {
        public string Medio { get; set; }
        public int Velocidad { get; set; }
        public int CostoPorKilometro { get; set; }
    }

    public class Medio
    {
        public string cMedio { get; set; }
    }

    public class Paqueteria
    {
        public string cPaqueteria { get; set; }
        public double MargenUtilidad { get; set; }
        public List<Medio> Medios { get; set; }
    }

    public class PaquetriasTransporteDTO
    {
        public List<MediosTransporte> MediosTransporte { get; set; }
        public List<Paqueteria> Paqueterias { get; set; }
    }
}
