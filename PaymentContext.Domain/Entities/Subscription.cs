using Flunt.Validations;
using PaymentContext.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Subscription : Entity
    {
        private IList<Payment> _payments;
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }

        public IReadOnlyCollection<Payment> Payments { get { return _payments.ToList(); } }

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }
        public void AddPayment(Payment payment)
        {
            AddNotifications(new CreateSubscriptionContract(payment));

            _payments.Add(payment);
        }
        public void Activate()
        {
            Active = true;
            LastUpdateDate = DateTime.Now;
        }
        public void Inactivate()
        {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
    public class CreateSubscriptionContract : Contract<Payment>
    {
        public CreateSubscriptionContract(Payment payment)
        {
            Requires()
               .IsGreaterOrEqualsThan(DateTime.Now, payment.PaidDate, "Subscription.Payments", "A data do pagamento deve ser futura");
        }
    }
}
