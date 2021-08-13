using PaymentContext.Domain.ValueObjects;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private List<Subscription> _subscriptions;
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }

        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public Student(Name name, Document document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public void AddSubscription(Subscription subscription)
        {
            foreach (Subscription sub in Subscriptions)
            {
                sub.Inactivate();
            }

            _subscriptions.Add(subscription);
        }
    }
}
