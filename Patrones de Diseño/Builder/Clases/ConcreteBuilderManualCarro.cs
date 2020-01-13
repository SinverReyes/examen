using Builder.Interfaces;

namespace Builder.Clases
{
    public class ConcreteBuilderManualCarro : IBuilder
    {
        private ManualCarro _manualcarro = new ManualCarro();

        public ConcreteBuilderManualCarro()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._manualcarro = new ManualCarro();
        }

        public void BuildCinturones()
        {
            this._manualcarro.Add("\tDocumentando... Cinturones");
        }

        public void BuildMotor(ITipoMotor tipomotor)
        {
            this._manualcarro.Add("\tDocumentando... Motor");
        }

        public void BuildGPS()
        {
            this._manualcarro.Add("\tDocumentando... GPS");
        }

        public void BuildBocinas()
        {
            this._manualcarro.Add("\tDocumentando... Bocinas");
        }

        public ManualCarro GetProduct()
        {
            ManualCarro result = this._manualcarro;

            this.Reset();

            return result;
        }
    }
}
