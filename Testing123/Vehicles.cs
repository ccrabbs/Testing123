using System.Collections;
using System.Collections.Generic;

namespace Testing123
{
    internal class Vehicles : IEnumerable<Vehicle>
    {
        internal List<Vehicle> VehicleList = new();
        internal Vehicles()
        { }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return ((IEnumerable<Vehicle>)VehicleList).GetEnumerator();
        }

        internal void AddVehicle(int id, string model)
        {
            VehicleList.Add(new Vehicle(id, model));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)VehicleList).GetEnumerator();
        }
    }
}