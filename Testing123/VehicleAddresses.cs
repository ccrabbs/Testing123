using System.Collections;
using System.Collections.Generic;

namespace Testing123
{
    internal class VehicleAddresses :IEnumerable<VehicleAddress>
    {
        internal List<VehicleAddress> VehicleAddressList = new();

        internal VehicleAddresses()
        {
            VehicleAddressList = new List<VehicleAddress>();
        }

        public IEnumerator<VehicleAddress> GetEnumerator()
        {
            return ((IEnumerable<VehicleAddress>)VehicleAddressList).GetEnumerator();
        }

        internal void AddVehicleAddresses(int Id, string Address)
        {
            VehicleAddressList.Add(new VehicleAddress(Id, Address));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)VehicleAddressList).GetEnumerator();
        }
    }
}
