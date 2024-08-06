using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productManagementSystem1
{
    internal class Category
    {

        public int CatId { get; set; }
        public string CatName { get; set; }    

        public string Description { get; set; } 

        public void TagCategory()  // Will tag the category with the products 
        {
            Console.WriteLine("Product successfully tagged with provided category !!");
        }

        public int CountCategory(string product_name)  // Will provide the count of the the products present in the category //
        {
            return 1;
        }
        

    }
}
