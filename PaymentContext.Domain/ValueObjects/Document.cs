using System.Collections.Generic;
using Flunt.Notifications;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        private IList<Notification> _notifications;

        public Document(string numer, EDocumentType type)
        {
            Numer = numer;
            Type = type;
            _notifications = new List<Notification>();

            AddNotifications(_notifications);
        }

        public string Numer { get; private set; }
        public EDocumentType Type { get; set; }
    }
}