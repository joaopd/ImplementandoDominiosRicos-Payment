using PaymentContext.Shared;

namespace PaymentContext.Domain.Commands
{
    public class CommandResult : ICommandReult
    {
        public CommandResult()
        {

        }
        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }

    }
}
