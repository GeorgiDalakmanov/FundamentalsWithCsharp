using System.IO.Compression;
class Program
{
    internal class Vehicle
    {
        public string Type { get; }

        public string Model { get; }

        public string Color { get; }

        public int HorsePower { get; }



        public Vehicle(string type, string model, string color, int horsePower)
        {
            switch (type)
            {
                case "car":
                    Type = "Car";
                    break;
                case "truck":
                    Type = "Truck";
                    break;
            }

            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Hoursepower: {HorsePower}";
        }

    }
    
        static void Main()
        {

            List<Vehicle> catalogue = new List<Vehicle>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                int hp = int.Parse(arguments[3]);


                catalogue.Add(new Vehicle(type,model,color,hp));
            }

            while ((input = Console.ReadLine()) != "Close the Catalog")
            {
                string vehicleModel = input;

                Vehicle foundVehicle = catalogue.FirstOrDefault(v => v.Model == vehicleModel);

                if (foundVehicle != null)
                {
                    Console.WriteLine(foundVehicle);
                }
            }

            double avarageHp = catalogue
                .Where(v => v.Type == "Car")
                .Select(v => v.HorsePower)
                .DefaultIfEmpty()
                .Average();
        Console.WriteLine($"Cars have average horsepower of {avarageHp:f2}.");

           avarageHp = catalogue
                .Where(v => v.Type == "Truck")
                .Select(v => v.HorsePower)
                .DefaultIfEmpty()
                .Average();
        Console.WriteLine($"Trucks have average horsepower of {avarageHp:f2}.");

        }

}

