using System.Collections.Generic;
using Flunt.Notifications;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        private IList<Notification> _notifications;

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            _notifications = new List<Notification>();

            if (string.IsNullOrEmpty(FirstName))
                _notifications.Add(new Notification(nameof(FirstName), "Nome inválido!"));

            AddNotifications(_notifications);
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}