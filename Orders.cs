using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productManagementSystem1
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; private set; }

        // Constructor
        public Orders(int orderId, string customerName, DateTime orderDate)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderDate = orderDate;
            Items = new List<OrderItem>();
        }

        // Methods
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public decimal CalculateTotal()
        {
            return Items.Sum(item => item.TotalPrice);
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Order Date: {OrderDate.ToShortDateString()}");
            Console.WriteLine("Items:");
            foreach (var item in Items)
            {
                Console.WriteLine($" - {item.ProductName}: {item.Quantity} x {item.UnitPrice:C} = {item.TotalPrice:C}");
            }
            Console.WriteLine($"Total: {CalculateTotal():C}");
        }
    }

    public class OrderItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal TotalPrice => Quantity * UnitPrice;

        public OrderItem(string productName, int quantity, decimal unitPrice)
        {
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
