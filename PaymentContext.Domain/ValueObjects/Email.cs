using System.Collections.Generic;
using Flunt.Notifications;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        private IList<Notification> _notifications;

        public Email(string address)
        {
            Address = address;
            _notifications = new List<Notification>();

            AddNotifications(_notifications);
        }

        public string Address { get; private set; }
    }
}