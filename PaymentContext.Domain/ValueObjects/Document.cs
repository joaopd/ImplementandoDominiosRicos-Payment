using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document
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
