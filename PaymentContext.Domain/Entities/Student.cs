using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private List<Subscription> _subscriptions;
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }

        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public void AddSubscription(Subscription subscription)
        {
            bool hasSubscriptionAtive = false;
            foreach (Subscription sub in _subscriptions)
            {
                if (sub.Active)
                {
                    hasSubscriptionAtive = true;
                }
            }

            if (hasSubscriptionAtive)
            {
                AddNotification("Student.Subscriptions", "Voce ja tem uma assinatura ativa");
            }
        }
    }
}
