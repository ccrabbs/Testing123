namespace Testing123
{
    internal class VehicleAddress
    {
        internal int Id { get; }
        internal string Address { get; }
        internal VehicleAddress(int id, string address)
        {
            Id = id;
            Address = address;
        }
    }
}