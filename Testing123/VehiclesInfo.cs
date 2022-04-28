using System.Collections.Generic;

namespace Testing123
{
    internal class VehiclesInfo
    {
        public int Id { get; set; }
        public List<string> AddressList { get; set; }

        internal Dictionary<int, List<string>> VehiclesInfoList = new ();
        internal VehiclesInfo()
        {
            VehiclesInfoList = new Dictionary<int, List<string>>();
        }
        internal void VehiclesInfoAdd(int id, string address)
        {
            List<string> AddressList = new();
            AddressList.Add(address);
            VehiclesInfoList.Add( id, AddressList);
        }
        internal void VehiclesInfoAddressAdd(int id, string address)
        {
            if (!VehiclesInfoList.ContainsKey(id))
                VehiclesInfoAdd(id,address);
        }
    }
}