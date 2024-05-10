namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> list = new List<Box>();

            string input = Console.ReadLine();
            while (input!="end")
            {
                //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
                string[] arguments = input.Split();
                int serialNumber =int.Parse( arguments[0]);
                string name = arguments[1];
                int itemQuantity =int.Parse(arguments[2]);
                decimal price = decimal.Parse(arguments[3]);
                Item item = new Item(name, price);
                Box box = new Box(serialNumber,item,itemQuantity,price);
                list.Add(box);
                input = Console.ReadLine();
            }
/*
             Box highestPriceBox = list[0];
foreach (Box box in list)
{
    if (box.PriceBox > highestPriceBox.PriceBox)
    {
        highestPriceBox = box;
    }
}
             */
            foreach (Box box in list.OrderByDescending(b => b.PriceBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }
    /*
     * 
     *  
19861519 Dove 15 2.50
86757035 Butter 7 3.20
39393891 Orbit 16 1.60
37741865 Samsung 10 1000
end
    */
    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    
    class Box
    {
        public Box(int serialNumber, Item item, int itemQuantity, decimal priceBox)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            priceBox = itemQuantity * Item.Price;
            PriceBox = priceBox;
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceBox { get; set; }
    }
}
