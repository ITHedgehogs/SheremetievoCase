using System.ComponentModel;
    
using Neo;
using Neo.SmartContract;
using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services;


namespace smartcontract
{
    [DisplayName("SheremetegoLocationOwnership")]
    [ManifestExtra("Author", "Hedgehogs")]
    [ManifestExtra("Description", "A contract for managing rent at SVO airport")]
    public class smartcontract : SmartContract
    {
        [InitialValue("NimiqChy6z2FyXDTyfX7qrq1JVLTEM1rc3", ContractParameterType.Hash160)]
        static readonly UInt160 Owner = default;

        private static readonly string locationKey = "location";
        private static readonly string lessorKey = "lessor";
        private static readonly string dateKey = "expirationDate";

        [DisplayName("register")]
        public static bool Register(UInt160 lessor, string location, string leaseEnds)
        {
            if (!Verify())
                return false;
            
            var map = new StorageMap(Storage.CurrentContext, location);
            if (map.Get(locationKey) is not null)
                return false;
            
            map.Put(locationKey, location);
            map.Put(lessorKey, lessor);
            map.Put(dateKey, leaseEnds);
            return true;
        }

        [DisplayName("remove")]
        public static bool Remove(string location)
        {
            if (!Verify())
                return false;

            var map = new StorageMap(Storage.CurrentContext, location);
            if (map.Get(locationKey) is null)
                return false;
            
            map.Delete(locationKey);
            map.Delete(lessorKey);
            map.Delete(dateKey);
            return true;
        }

        [DisplayName("update")]
        public static bool Update(string location, string date)
        {
            if (!Verify())
                return false;
            
            var map = new StorageMap(Storage.CurrentContext, location);
            if (map.Get(locationKey) is null)
                return false;
            
            map.Put(dateKey, date);
            return true;
        }
        
        public static bool Verify()
        {
            return Runtime.CheckWitness(Owner);
        }
    }
}
