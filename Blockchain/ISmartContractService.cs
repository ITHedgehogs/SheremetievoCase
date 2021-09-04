using System;

namespace Blockchain
{
    public interface ISmartContractService
    {
        void OwnLocation(string lessorWallet, string locationId, DateTime leaseExpiration);

        void UpdateLeaseExpiration(string locationId, DateTime leaseExpiration);

        void DeleteLocationOwner(string locationId);

        string GetLessorWallet(string locationId);

        DateTime GetLeaseExpiration(string locationId);
    }
}