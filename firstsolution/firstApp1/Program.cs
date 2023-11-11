using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class ShoppingHome
    {
        void DisplayAdminMenu()
        {
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Update Product Price");
            Console.WriteLine("3.Delete Product");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Shopping App");
            ShoppingHome home = new ShoppingHome();
            home.DisplayAdminMenu();
        }
    }
}
