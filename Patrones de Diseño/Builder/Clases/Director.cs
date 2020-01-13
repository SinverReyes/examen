
using Builder.Interfaces;

namespace Builder.Clases
{
    public class Director
    {
        private IBuilder _builder;
        private ITipoMotor _tipomotor;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void CarBuilder()
        {
            this._builder.BuildCinturones();
            this._builder.BuildMotor(_tipomotor);
            this._builder.BuildGPS();
            this._builder.BuildBocinas();
        }

        public void ManualCarBuilder()
        {
            this._builder.BuildCinturones();
            this._builder.BuildMotor(_tipomotor);
            this._builder.BuildGPS();
            this._builder.BuildBocinas();
        }
    }
}
