using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Blockchain
{
    public class BlockchainService : IBlockchainService
    {
        private static readonly Dictionary<string, BigInteger> NodeWallet = new();

        public string CreateNewWallet()
        {
            var random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrtuvwxyz0123456789";
            
            return new string(Enumerable.Repeat(chars, 35).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
        /// <summary>
        /// Gets amount of money in specified wallet
        /// </summary>
        /// <param name="wallet">Wallet id that was create for user</param>
        /// <returns>Amount of money in wallet. If wallet does not exist returns 0</returns>
        public BigInteger GetMoneyInWallet(string wallet)
        {
            return NodeWallet.TryGetValue(wallet, out var val) ? val : 0;
        }

        public void PutMoneyInWallet(string wallet, BigInteger amount)
        {
            NodeWallet[wallet] = GetMoneyInWallet(wallet) + amount;
        }

        public void PullMoneyFromWallet(string wallet, BigInteger amount)
        {
            if (GetMoneyInWallet(wallet) >= amount)
                NodeWallet[wallet] = GetMoneyInWallet(wallet) - amount;
        }
    }
}