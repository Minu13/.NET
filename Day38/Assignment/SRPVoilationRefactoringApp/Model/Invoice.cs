using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPVoilationRefactoringApp.Model
{
    internal class Invoice
    {
        private readonly int _id;
        private readonly string _description;
        private readonly double _cost;
        private readonly double _discountPercent;
        private const double _tax = .10;

        public Invoice(int id, string description, double cost, double disocunt)
        {
            _id = id;
            _description = description;
            _cost = cost;
            _discountPercent = disocunt;

        }
        public int Id
        {
            get { return _id; }
        }

        public string Description
        {
            get { return _description; }
        }

        public double Cost
        {
            get { return _cost; }
        }

        public double DiscountPercent
        {
            get { return _discountPercent; }
        }

        public double CalculateTax()
        {
            return _cost * _tax;
        }

        public double CalculateDiscount()
        {
            return _cost * _discountPercent;
        }

        public double FinalCost()
        {
            return _cost + CalculateTax() - CalculateDiscount();
        }

    }
}