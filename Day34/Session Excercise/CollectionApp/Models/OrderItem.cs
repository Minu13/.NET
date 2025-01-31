using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CollectionApp.Models
{
    class OrderItem
    {
        private int _id;
        private string _name;
        private double _unitPrice;
        private int _quantity;

        public OrderItem(int id, string name, double unitprice, int quantity)
        {
            _id = id;
            _name = name;
            _unitPrice = unitprice;
            _quantity = quantity;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double UnitPrice { get { return _unitPrice; } }
        public int Quantity { get { return _quantity; } }

        public double LineItemcost
        {
            get
            {
                return _quantity * _unitPrice;
            }
        }
    }
}
