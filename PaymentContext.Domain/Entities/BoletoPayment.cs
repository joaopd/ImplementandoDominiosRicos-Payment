using System;
using System.Reflection.Metadata;

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
            BarCode = barCode;
            BoletoNuber = boletoNuber;
        }
    }
}
