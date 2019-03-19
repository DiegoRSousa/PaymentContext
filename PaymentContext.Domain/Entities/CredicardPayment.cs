using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities {
    public class CrediCardPayment : Payment
    {
        public CrediCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber, 
            DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, 
            Document document, Address address, Email email) 
            : base(paidDate, expireDate, total, totalPaid, owner, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransationNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransationNumber { get; private  set; }
    }  
}