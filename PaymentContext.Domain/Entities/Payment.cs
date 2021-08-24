﻿using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System;


namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, Document document, string payer, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Address = address;
            Document = document;
            Payer = payer;
            Email = email;

            AddNotifications(new CreatePaymentContract(this));
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public Address Address { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Payer { get; private set; }
    }
    public class CreatePaymentContract : Contract<Payment>
    {
        public CreatePaymentContract(Payment payment)
        {
            Requires()
               .IsGreaterThan(0, payment.Total, "Payment.Total", "o total nao pode ser zero")
               .IsGreaterOrEqualsThan(payment.Total, payment.TotalPaid, "Payment.TotalPaid", "O valor pago e menor que o valor do pagamento");
        }
    }
}
