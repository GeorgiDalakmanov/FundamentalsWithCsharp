namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main()
        {
            VenchileCatalog catalog = new VenchileCatalog();
            // line -- split()
            // if Truck --- catalog.Truck.Add( new Trucks)
            // if Car --- catalog.Cars.Add( new Cars)
        }
    }

    class VenchileCatalog
    {
        public List<Truck> Trucks { get; set; }
        
        public List<Car> Cars { get; set; }
    }

    class Truck
    {
        public string  Brand { get; set; }

        public string Model { get; set; }   

        public string Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string HorsePower { get; set; }
    }
}
