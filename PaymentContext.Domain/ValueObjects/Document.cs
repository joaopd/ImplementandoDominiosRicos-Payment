using Flunt.Validations;
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

            AddNotifications(new CreateDocumentContract(this));
        }

        public EDocumentType Type { get; private set; }
        public string Number { get; private set; }

        public bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
            {
                return true;
            }

            if (Type == EDocumentType.CPF && Number.Length == 11)
            {
                return true;
            }

            return false;
        }
    }

    public class CreateDocumentContract : Contract<Document>
    {
        public CreateDocumentContract(Document document)
        {
            Requires()
            .IsTrue(document.Validate(), "Document.Number", "Documento invalido");
        }
    }
}
