using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            //validações
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
            => $"{FirstName} {LastName}";
    }
}