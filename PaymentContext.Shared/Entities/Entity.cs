using Flunt.Notifications;
using System;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable<Notification>
    {
        public Guid Id { get; private set; }
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
