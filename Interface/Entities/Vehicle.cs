

namespace Interface.Entities
{
    internal class Vehicle
    {
        public Vehicle()
        {
        }

        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
