using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIterateDesignPatternApp.Models
{
    public class MyNamesIterator
    {
        private List<string> _names;
        private int _currentIndex = -1;

        public MyNamesIterator(List<string> names)
        {
            _names = names;
        }

        
        public bool HasNext()
        {
            return _currentIndex + 1 < _names.Count;
        }

       
        public string Next()
        {
            if (HasNext())
            {
                _currentIndex++;
                return _names[_currentIndex];
            }
            return null; 
        }
    }
}
