using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Shared.Handler
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandReult Handle(T comand);
    } 
}
