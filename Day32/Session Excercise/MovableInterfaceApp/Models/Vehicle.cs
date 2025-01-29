using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp.Models
{
    abstract class Vehicle : IMovable
    {
        private readonly string _brandname;
        private readonly string _chasisno;

        public Vehicle(string brandname ,string chasisno)
        {
            _brandname = brandname;
            _chasisno = chasisno;
        }
        public string Brandname { get { return _brandname; } }
        public string Chasisno { get { return _chasisno; } }

        public abstract void Move();
        
    }
}
