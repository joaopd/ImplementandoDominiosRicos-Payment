using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Shared
{
    public interface ICommand
    {
        void validate();
    }
}
