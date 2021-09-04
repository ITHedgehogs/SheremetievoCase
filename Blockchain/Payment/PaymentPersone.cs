using System;
using System.Numerics;
using Blockchain.Persone;

namespace Blockchain.Payment
{
    public class PaymentPersone : IBlockchainService
    {
        public Wallet wallet { get; private set; }
        public BigInteger Id;

        public PaymentPersone()
        {
            Id = PaymentInformation.NumberOfPerson;
        }

        public string CreateNewWallet()
        {
            wallet = new Wallet(Id);
            return wallet.Id.ToString();
        }

        public BigInteger GetMoneyInWallet(string wallet) // аргумент wallet нам не нужен
        {
            return this.wallet.NumberOfMoney;
        }

        public void PullMoneyFromWallet(string wallet, BigInteger amount)
        {
            this.wallet.ChangeMoney(-amount);
        }

        public void PutMoneyInWallet(string wallet, BigInteger amount)
        {
            this.wallet.ChangeMoney(amount);
        }


    }
}
