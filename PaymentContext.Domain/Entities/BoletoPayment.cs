using PaymentContext.Domain.ValueObjects;
using System;


namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public string BarCode { get; private set; }
        public string BoletoNuber { get; private set; }
        public BoletoPayment(
            string barCode,
            string boletoNuber,
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
            BarCode = barCode;
            BoletoNuber = boletoNuber;
        }
    }
}
