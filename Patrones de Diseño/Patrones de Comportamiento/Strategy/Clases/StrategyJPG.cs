using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Clases
{
    public class StrategyJPG : IGuardarImagen
    {
        public string SaveImg(string name)
        {
            return name + ".JPG";
        }
    }
}
