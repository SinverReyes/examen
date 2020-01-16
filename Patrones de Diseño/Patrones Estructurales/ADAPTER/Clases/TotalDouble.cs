namespace ADAPTER
{
    public class TotalDouble : ITotaldouble
    {
        public AdaptadorStringDouble obtenerTotal;
        public TotalDouble(AdaptadorStringDouble _obtenerTotal)
        {
            obtenerTotal = _obtenerTotal;
        }

        public double ObtenerValorTotalDouble()
        {
            double valor=0;

            valor = obtenerTotal.ObtenerValorTotalDouble();

            return valor;
        }
    }
}
