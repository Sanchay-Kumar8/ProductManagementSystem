using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productManagementSystem1
{
    internal class Products
    {
        public int prodId { get; set; }
        public string prodName { get; set; }
        public int prodPrice { get; set; }
        public string prodDescription { get; set; }

        public void AddProduct()
        {
            Console.WriteLine("Product added successfully");
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Product deleted successfully");
        }

        public int GetProductById(int id)
        {
            id = 0;
            Console.WriteLine("Product fetched successfully");
            return id;
        }

        public void UpdateProduct(int id)
        {
            Console.WriteLine("Product updated successfully");
        }

    }
}
