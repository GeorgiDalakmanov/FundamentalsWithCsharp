


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

        public void Update(decimal newPrice, decimal newQuantity)
        {
           Price = newPrice;
           Quantity += newQuantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {Sum():F2}";
        }

        private decimal Sum()
        {
            return Price * Quantity;
        }
    }
    static void Main()
    {
        Dictionary<string,Product> products = new Dictionary<string,Product>();

        string input;
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] args = input.Split();
            
            string name = args[0];
            decimal price = decimal.Parse(args[1]);
            decimal quantity = decimal.Parse(args[2]);

            Product newProduct = new Product(name,price,quantity);

            if (!products.ContainsKey(newProduct.Name))
            {
                products.Add(newProduct.Name, newProduct);
            }

            else
            {
                products[newProduct.Name].Update(newProduct.Price, newProduct.Quantity);
     
            }
        }
        foreach (var productPair in products)
        {
            Console.WriteLine(productPair.Value);
        }
    }
}

