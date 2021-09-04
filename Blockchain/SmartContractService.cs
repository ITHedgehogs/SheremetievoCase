using System;
using Neo;
using Neo.Network.RPC;

namespace Blockchain
{
    public class SmartContractService : ISmartContractService
    {
        private static RpcClient _client = new RpcClient(new Uri("http://127.0.0.1:50012"), 
            null, null, ProtocolSettings.Load("node1.config.json"));
        
        public void OwnLocation(string lessorWallet, string locationId, DateTime leaseExpiration)
        {
            throw new NotImplementedException();
        }

        public void UpdateLeaseExpiration(string locationId, DateTime leaseExpiration)
        {
            throw new NotImplementedException();
        }

        public void DeleteLocationOwner(string locationId)
        {
            throw new NotImplementedException();
        }

        public string GetLessorWallet(string locationId)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLeaseExpiration(string locationId)
        {
            throw new NotImplementedException();
        }
    }
}