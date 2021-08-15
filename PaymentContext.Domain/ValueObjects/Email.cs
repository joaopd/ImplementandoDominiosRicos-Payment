using Flunt.Validations;
using PaymentContext.Shared;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string addres)
        {
            Addres = addres;

            AddNotifications(new Contract());
        }

        public string Addres { get; private set; }
    }
}
