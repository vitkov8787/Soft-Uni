namespace _03._Orders
{
    /*
Beer 2.40 350
Water 1.25 200
IceTea 5.20 100
Beer 1.20 200
IceTea 0.50 120
buy
     */
    internal class Program
    {
        class Product
        {
            public Product(string name, decimal price, decimal quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
           // public decimal Tottal => Price * Quantity;
          
            public decimal tottalPrice() {
                return Price * Quantity;
            }
            public void Update(decimal newPrice, decimal newQuantity)
            {
                Price = newPrice;
                Quantity += newQuantity;
            }
            public override string ToString()
            {
                return $"{Name} -> {tottalPrice():F2}";
            }

        }
        static void Main(string[] args)
        {
            Dictionary<string,Product> productsDictionary = new Dictionary<string,Product>();
            string input;
            while ((input=Console.ReadLine())!="buy")
            {
                string[] arg = input.Split();
                
                Product itemProduct=new Product(
                    arg[0],
                    decimal.Parse(arg[1]),
                    decimal.Parse(arg[2]));

                if(!productsDictionary.ContainsKey(itemProduct.Name))
                {
                    productsDictionary.Add(itemProduct.Name, itemProduct);
                }
                else
                {
                    productsDictionary[itemProduct.Name].Update(itemProduct.Price,itemProduct.Quantity);
                }
                
            }
            foreach (var item in productsDictionary)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
