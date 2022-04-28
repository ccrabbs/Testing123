using System.Collections.Generic;

namespace Testing123
{
    internal class VehicleAddresses 
    {
        internal List<VehicleAddress> VehicleAddressList = new();

        internal VehicleAddresses()
        {
            VehicleAddressList = new List<VehicleAddress>();
        }
        internal void AddVehicleAddresses(int Id, string Address)
        {
            VehicleAddressList.Add(new VehicleAddress(Id, Address));
        }
    }
}
