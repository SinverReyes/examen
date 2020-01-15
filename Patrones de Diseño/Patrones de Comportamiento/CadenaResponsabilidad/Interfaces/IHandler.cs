
namespace CadenaResponsabilidad
{
    public interface IHandler
    {
        IHandler NextNivel(IHandler handler);

        string Handle(double costo);
    }
}
