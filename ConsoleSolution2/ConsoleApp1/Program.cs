namespace ConsoleApp1
{
    namespace ShoppingApp
    {
        internal class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public float Price { get; set; }
            public string Picture { get; set; }
            public string Description { get; set; }
            public double Rating { get; set; }
            public double Discount { get; set; }
            public Product()
            {
                Price = 0.0f;
                Discount = 0.5f;
                Quantity = 1;
            }

            public Product(int id, string name, int quantity, float price, string description, double rating, double discount)
            {
                Id = id;
                Name = name;
                Quantity = quantity;
                Price = price;
                //Picture = picture;
                Description = description;
                Rating = rating;
                Discount = discount;
            }
        }
        public class Program
        {
             public static void Main(String[] args)
            {
                Product product1 = new Product(2, "mary", 3, 4.0f, "hello", 3, 6);
                Product product2 = new Product();
                Console.WriteLine($"ID:{product1.Id}");
                Console.WriteLine($"Name:{product1.Name}");
            }
        }
    }
}
