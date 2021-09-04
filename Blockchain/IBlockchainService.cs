using System.Numerics;

namespace Blockchain
{
    public interface IBlockchainService
    {
        string CreateNewWallet();

        BigInteger GetMoneyInWallet(string wallet);

        void PutMoneyInWallet(string wallet, BigInteger amount);

        void PullMoneyFromWallet(string wallet, BigInteger amount);
    }
}