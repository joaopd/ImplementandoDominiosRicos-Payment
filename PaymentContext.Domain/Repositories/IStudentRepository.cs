using PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Repositories
{
    public interface IStudentRepository
    {
        bool DocumentExist(string document);
        bool EmailExist(string email);
        bool CreateSubscription(Student student);
    }
}
