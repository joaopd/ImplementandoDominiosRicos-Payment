using Flunt.Validations;
using PaymentContext.Shared;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firsName, string lastName)
        {
            FirsName = firsName;
            LastName = lastName;

            if (string.IsNullOrEmpty(FirsName))
                AddNotification("Name.FirstName", "Nome Invalido");

            AddNotifications(new Contract()
              .IsLowerThan(FirsName, 40, "FirstName", "Name should have no more than 40 chars")
              .IsGreaterThan(FirsName, 3, "FirstName", "Name should have at least 3 chars")
  );

        }

        public string FirsName { get; private set; }
        public string LastName { get; private set; }
    }
}
