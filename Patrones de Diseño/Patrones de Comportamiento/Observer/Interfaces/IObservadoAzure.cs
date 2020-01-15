
namespace Observer.Interfaces
{
    public interface IObservadoAzure
    {
        void addObsevador(IObservador observador);
        void DeleteObsevador(IObservador observador);
        void Notificar(string _codigo, string _concepto);
    }
}
