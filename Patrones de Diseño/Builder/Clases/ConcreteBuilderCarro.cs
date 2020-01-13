using Builder.Interfaces;

namespace Builder.Clases
{
    public class ConcreteBuilderCarro : IBuilder
    {
        private ITipoMotor tipoMotor;
        private Carro _carro = new Carro();

        public ConcreteBuilderCarro()
        {
            this.Reset();
        }

        public ConcreteBuilderCarro(ITipoMotor tipoMotor)
        {
            this.tipoMotor = tipoMotor;
        }

        public void Reset()
        {
            this._carro = new Carro();
        }

        public void BuildCinturones()
        {
            this._carro.Add("\tConstruyendo... Cinturones");
        }

        public void BuildMotor(ITipoMotor tipomotor)
        {
            this._carro.Add("\tConstruyendo... Motor");
        }

        public void BuildGPS()
        {
            this._carro.Add("\tConstruyendo... GPS");
        }

        public void BuildBocinas()
        {
            this._carro.Add("\tConstruyendo... Bocinas");
        }

        public Carro GetProduct()
        {
            Carro result = this._carro;

            this.Reset();

            return result;
        }

    }
}
