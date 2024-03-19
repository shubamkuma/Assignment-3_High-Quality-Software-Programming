
namespace Assignment_3_High_Quality_Software_Programmning
{
    internal class RentalAgency
    {
        private int v;

        public RentalAgency(int v)
        {
            this.v = v;
        }

        public object TotalRevenue { get; internal set; }

        internal void AddVehicle(Vehicle car, int v)
        {
            throw new NotImplementedException();
        }

        internal void RentVehicle(Vehicle car)
        {
            throw new NotImplementedException();
        }
    }
}