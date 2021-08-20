using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            //validações
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; set; }

        private bool Validate()
        {
            if (Type.Equals(EDocumentType.CNPJ) && Number.Length.Equals(14))
                return true;

            if (Type.Equals(EDocumentType.CPF) && Number.Length.Equals(11))
                return true;

            return false;
        }
    }
}