
namespace CadenaResponsabilidad
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual string Handle(double _dCosto)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(_dCosto);
            }
            else
            {
                return null;
            }
        }

        public IHandler NextNivel(IHandler _handler)
        {
            this._nextHandler = _handler;

            return _handler;
        }
    }
}
