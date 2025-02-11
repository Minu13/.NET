using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorLambda.Models
{
    public class MathOperations
    {
        public string Add(int x, int y)
        {
            return $"Add: {x + y}";
        }

        public string Sub(int x, int y)
        {
            return $"Sub: {x - y}";
        }

        public string Muli(int x, int y)
        {
            return $"Muli: {x * y}";
        }
    }
}
