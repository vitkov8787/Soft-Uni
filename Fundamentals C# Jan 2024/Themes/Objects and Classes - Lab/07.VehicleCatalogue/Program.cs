namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string input = Console.ReadLine();

            while (input!="end")
            {
                string[] arguments = input.Split("/");
                string type = arguments[0];
                string brand = arguments[1];
                string model = arguments[2];
                string weightOrHp = arguments[3];
               
                if (type == "Car")
                {
                    Car car = new Car(brand, model, weightOrHp);
                    catalog.ListCars.Add(car);
                }else if(type == "Truck")
                {
                    Truck truck = new Truck(brand, model, weightOrHp);
                    catalog.ListTrucks.Add(truck);
                }
                input = Console.ReadLine();
            }
            catalog.ListCars = catalog.ListCars.OrderBy(car => car.Brand).ToList();
            catalog.ListTrucks = catalog.ListTrucks.OrderBy(truck => truck.Brand).ToList();
            if(catalog.ListCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.ListCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Hp}hp");
                }
            }
           
            if (catalog.ListTrucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.ListTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    /*
Car/Audi/A3/110
Car/Maserati/Levante/350
Truck/Mercedes/Actros/9019
Car/Porsche/Panamera/375
end
     */
    class Car
    {
        public Car(string brand,string model,string hp) 
        {
            Brand= brand;
            Model= model;
            Hp = hp;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Hp { get; set; }
    }
    class Truck
    {
        public Truck(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    class Catalog
    {
        public List<Car> ListCars { get; set; }
        public List<Truck> ListTrucks { get; set; }
        public Catalog()
        {
            
            ListCars = new List<Car>();
            ListTrucks = new List<Truck>();
        }
    }
}
