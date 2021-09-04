using System;
using System.Collections.Generic;
using System.Numerics;
using Blockchain.Persone;

namespace Blockchain.Payment
{
    public static class PaymentInformation
    {
        public static List<Order> TransactionsList = new List<Order>();
        public static List<PaymentPersone> PersoneList = new List<PaymentPersone>();
        public static List<Wallet> WalletList = new List<Wallet>();

        public static BigInteger CostPO = 1;

        public static BigInteger NumberOfPerson {
            get {
                NumberOfPerson++;
                return NumberOfPerson - 1;
            }
            private set { NumberOfPerson = value; }
        }
        public static BigInteger NumberOfTransactions = 0;

        public static BigInteger NumberOfPOPayments = 0;
    }
}
