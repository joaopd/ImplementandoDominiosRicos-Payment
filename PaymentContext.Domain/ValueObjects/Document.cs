using PaymentContext.Domain.Enums;
using PaymentContext.Shared;

namespace PaymentContext.Domain
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public EDocumentType Type { get; private set; }
        public string Number { get; private set; }
    }
}
