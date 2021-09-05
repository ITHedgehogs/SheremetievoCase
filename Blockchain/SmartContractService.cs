using System;
using System.Collections.Generic;

namespace Blockchain
{
    public class SmartContractService : ISmartContractService
    {
        private static readonly Dictionary<string, string> locationLessor = new();
        private static readonly Dictionary<string, DateTime> leaseExpiration = new();

        public void OwnLocation(string lessorWallet, string locationId, DateTime leaseExpirationDate)
        {
            locationLessor[locationId] = lessorWallet;
            leaseExpiration[locationId] = leaseExpirationDate;
        }

        public void UpdateLeaseExpiration(string locationId, DateTime leaseExpirationDate)
        {
            leaseExpiration[locationId] = leaseExpirationDate;
        }

        public void DeleteLocationOwner(string locationId)
        {
            locationLessor.Remove(locationId);
        }
        
        /// <summary>
        /// Gets wallet of entity that leases location
        /// </summary>
        /// <param name="locationId">Id or a name of the location</param>
        /// <returns>Returns wallet address if lease and 'NimiqChy6z2FyXDTyfX7qrq1JVLTEM1rc3' otherwise</returns>
        public string GetLessorWallet(string locationId)
        {
            return locationLessor.TryGetValue(locationId, out var val) ? 
                val : "NimiqChy6z2FyXDTyfX7qrq1JVLTEM1rc3";
        }
        
        /// <summary>
        /// Gets Lease Expiration Date
        /// </summary>
        /// <param name="locationId">Id or a name of the location</param>
        /// <returns>Expiration Date if successful and UnixEpoch otherwise</returns>
        public DateTime GetLeaseExpiration(string locationId)
        {
            return leaseExpiration.TryGetValue(locationId, out var dateTime) ? 
                dateTime : DateTime.UnixEpoch;
        }
    }
}