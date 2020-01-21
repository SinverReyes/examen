
namespace Composite
{
    public class DatosCP
    {
        public int id { get; set; }
        public double dTotalEnero { get; set; }
        public double dTotalFebrero { get; set; }
        public double dTotalMarzo { get; set; }
        public double dTotalAbril { get; set; }
  
         public DatosCP(int _id, double _dTotalEnero, double _dTotalFebrero, double _dTotalMarzo, double _dTotalAbril)
        {
            id = _id;
            dTotalEnero = _dTotalEnero;
            dTotalFebrero = _dTotalFebrero;
            dTotalMarzo = _dTotalMarzo;
            dTotalAbril = _dTotalAbril;
        }
    }
}
