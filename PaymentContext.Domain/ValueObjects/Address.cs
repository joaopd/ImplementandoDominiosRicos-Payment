using Flunt.Validations;
using PaymentContext.Shared;

namespace PaymentContext.Domain
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string ciry, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            Ciry = ciry;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new CreateAddressContract(this));
        }

        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string Ciry { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
    public class CreateAddressContract : Contract<Address>
    {
        public CreateAddressContract(Address address)
        {
            Requires()
              .IsLowerThan(address.Street, 40, "Street", "Street should have no more than 40 chars");
        }
    }
}
