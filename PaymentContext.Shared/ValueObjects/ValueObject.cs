using System.Collections.Generic;
using Flunt.Notifications;

namespace PaymentContext.Shared.ValueObjects
{
    public abstract class ValueObject : INotifiable
    {
        public void AddNotifications(IEnumerable<Notification> notifications)
        {
        }
    }
}