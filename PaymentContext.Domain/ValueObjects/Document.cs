using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string numer, EDocumentType type)
        {
            Numer = numer;
            Type = type;
        }

        public string Numer { get; private set; }
        public EDocumentType Type { get; set; }
    }
}