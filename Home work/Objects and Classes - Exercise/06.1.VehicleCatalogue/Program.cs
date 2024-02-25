namespace _06._1.VehicleCatalogue
{
        internal class Program
        {
            class Vehicle
            {
                public Vehicle(string typeOfVe, string model, string color, int horsePower)
                {
                    TypeOfVe = typeOfVe;
                    Model = model;
                    Color = color;
                    HorsePower = horsePower;
                }
                static string Capitalize(string input)
                {
                    return char.ToUpper(input[0]) + input.Substring(1);
                }
                public void PrintInfo()
                {
                    Console.WriteLine($"Type: {Capitalize(TypeOfVe)}\nModel: {Capitalize(Model)}\nColor: {Color}\nHorsepower: {HorsePower}");
                }
                public string TypeOfVe { get; set; }
                public string Model { get; set; }
                public string Color { get; set; }
                public int HorsePower { get; set; }

            }

            static void Main(string[] args)
            {

                List<Vehicle> listVehicle = new List<Vehicle>();
                string input;

                while ((input = Console.ReadLine()) != "End")
                {
                    string[] arg = input.Split();
                    Vehicle data = new Vehicle(arg[0], arg[1], arg[2], int.Parse(arg[3]));
                    listVehicle.Add(data);
                }
                string input2;
                while ((input2 = Console.ReadLine()) != "Close the Catalogue")
                {
                     Vehicle filt = listVehicle.FirstOrDefault(item=>item.Model== input2);
                     if (filt != null)
                     {
                         filt.PrintInfo();
                     }       
                }    
                double avg = listVehicle.Where(item => item.TypeOfVe == "car").Select(item => item.HorsePower).DefaultIfEmpty().Average();
                Console.WriteLine($"Cars have average horsepower of: {avg:F2}.");
                avg = listVehicle.Where(item => item.TypeOfVe == "truck").Select(item => item.HorsePower).DefaultIfEmpty().Average();
                Console.WriteLine($"Trucks have average horsepower of: {avg:F2}.");      
            }
        }
    }
/*
truck Man red 200
truck Mercedes blue 300
car Ford green 120
car Ferrari red 550
car Lamborghini orange 570
End
Ferrari
Ford
Man
Close the Catalogue
 */
