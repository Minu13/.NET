using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIterateDesignPatternApp.Models
{
    public class MyNamesCollection
    {
        private List<string> _names = new List<string>();

        public void AddName(string name)
        {
            _names.Add(name);
        }
                
        public MyNamesIterator GetIterator()
        {
            return new MyNamesIterator(_names);
        }
    }
}
