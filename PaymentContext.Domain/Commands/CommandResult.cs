using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CommandResult: ICommandResult
    {
        public CommandResult()
        {
            
        }
        public CommandResult(bool suscess, string message)
        {
            Suscess = suscess;
            Message = message;
        }

        public bool Suscess { get; set; }
        public string Message { get; set; }
        
    }
}