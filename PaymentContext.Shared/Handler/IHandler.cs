namespace PaymentContext.Shared.Handler
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandReult Handle(T comand);
    }
}
