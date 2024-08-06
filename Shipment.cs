using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productManagementSystem1
{
    public class Shipment
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Address { get; set; }
        public int ShipmentCost { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public DateTime ExpectedDateOfDelivery { get; set; }


        public int GetShipmentID()
        {
            return OrderID;
        }

        public int GetShipmentCost()
        {
            return ShipmentCost;
        }

    }
}
