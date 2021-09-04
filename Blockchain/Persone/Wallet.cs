using System;
using System.Numerics;

namespace Blockchain.Persone
{
    public class Wallet
    {
        public readonly BigInteger Id; // id
        public readonly BigInteger IdOwner; // Id владельца кошелька
        public BigInteger NumberOfMoney { get; private set; } // Количество денег


        public Wallet(BigInteger idOwner)
        {
            this.IdOwner = idOwner;
        }

        public void ChangeMoney(BigInteger number)
        {
            NumberOfMoney += number;
        }
    }
}
