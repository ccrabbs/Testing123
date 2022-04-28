using System.Collections.Generic;

namespace Testing123
{
    internal class Vehicles
    {
        internal List<Vehicle> VehicleList = new();
        internal Vehicles()
        { }

        internal void AddVehicle(int id, string model)
        {
            VehicleList.Add(new Vehicle(id, model));
        }
    }
}