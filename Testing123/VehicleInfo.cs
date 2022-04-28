namespace Testing123
{
    internal class VehicleInfo
    {
        internal int Id;
        internal List< string> Addresses = new() { };
        internal VehicleInfo(int id, string address)
        {
            Id = id;
            Addresses.Add(address);
        }
    }
}