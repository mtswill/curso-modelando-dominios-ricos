using System;
using System.Collections.Generic;
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : INotifiable
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
        }
    }
}