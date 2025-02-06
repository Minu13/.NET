using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodooCommonLib.Model
{
    public class Todo
    {
        public string Description { get; set; }
        public string Priority { get; set; }

        public Todo() { }

        public Todo(string description, string priority)
        {
            Description = description;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"Description: {Description}, Priority: {Priority}";

        }

    }
}

