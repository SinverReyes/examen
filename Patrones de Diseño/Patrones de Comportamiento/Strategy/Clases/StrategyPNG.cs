using Strategy.Interfaces;
using System;

namespace Strategy.Clases
{
    public class StrategyPNG : IGuardarImagen
    {
        public string SaveImg(string name)
        {
            return name + ".PNG";
        }
    }
}
