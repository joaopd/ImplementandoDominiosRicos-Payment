using System;
using System.Reflection.Metadata;

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
            TransactionCode = transactionCode;
        }
    }
}
