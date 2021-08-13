using System;
using System.Reflection.Metadata;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
        public CreditCardPayment(string cardHolderName,
            string cardNumber,
            string lastTransactionNumber,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string address,
            Document document,
            string payer,
            string email)
            : base(
                  paidDate,
                  expireDate,
                  total,
                  totalPaid,
                  address,
                  document,
                  payer,
                  email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }
    }
}
