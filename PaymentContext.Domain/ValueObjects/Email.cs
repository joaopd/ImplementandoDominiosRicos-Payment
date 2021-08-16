using Flunt.Validations;
using PaymentContext.Shared;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new CreateEmailContract(this));
        }

        public string Address { get; private set; }
    }
    public class CreateEmailContract : Contract<Email>
    {
        public CreateEmailContract(Email email)
        {
            Requires()
                .IsEmail(email.Address, "Email");
        }
    }
}
