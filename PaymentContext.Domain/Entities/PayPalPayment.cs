using PaymentContext.Domain.ValueObjects;
using System;


namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; private set; }
        public PayPalPayment(
            string transactionCode,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            Address address,
            Document document,
            string payer,
            Email email)
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
            TransactionCode = transactionCode;
        }
    }
}
