namespace ADAPTER
{
    public class AdaptadorStringDouble : ITotaldouble
    {
        private ITotalString obtenerTotal;

        public AdaptadorStringDouble(ITotalString _obtenerTotal)
        {
            obtenerTotal = _obtenerTotal;
        }

        public double ObtenerValorTotalDouble()
        {
            string totalString = obtenerTotal.ObtenerValorTotalString();

            double TotalDouble = double.Parse(totalString);

            return TotalDouble;
        }
    }
}
