
namespace Builder.Interfaces
{
    //es todo lo que sabe hacer el obrero o constructor
    public interface IBuilder
    {
        void BuildCinturones();

        void BuildMotor(ITipoMotor tipomotor);

        void BuildGPS();

        void BuildBocinas();
    }
}
