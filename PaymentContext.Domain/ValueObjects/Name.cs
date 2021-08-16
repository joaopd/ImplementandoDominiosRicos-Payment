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

            AddNotifications(new CreateNameContract(this));

        }

        public string FirsName { get; private set; }
        public string LastName { get; private set; }
    }
    public class CreateNameContract : Contract<Name>
    {
        public CreateNameContract(Name name)
        {
            Requires()
              .IsLowerThan(name.FirsName, 40, "FirstName", "Name should have no more than 40 chars")
              .IsGreaterThan(name.FirsName, 3, "FirstName", "Name should have at least 3 chars");
        }
    }
}
