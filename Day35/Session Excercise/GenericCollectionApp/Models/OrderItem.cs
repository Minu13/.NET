using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionApp.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quanity { get; set; }

        public double LineItemCost
        {
            get
            {
                return Quanity * UnitPrice;
            }
        }
        public override string ToString()
        {
            return $" Id is {this.Id} , name is {this.Name} Quantity  {this.Quanity} unitprice is {this.UnitPrice} , LineItemcost {this.LineItemCost}";
        }
    }
}
