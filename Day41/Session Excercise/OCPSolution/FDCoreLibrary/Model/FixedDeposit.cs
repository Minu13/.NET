using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDCoreLibrary.Model
{
    public class FixedDeposit
    {
        private readonly int _accno;
        private readonly string _name;
        private readonly double _principleAmount;
        private readonly int _duration;
        private readonly DCalculateRate _ratePolicy;

        public FixedDeposit(int accno, string name, double princple, int duration, DCalculateRate ratePolicy)
        {

            _accno = accno;
            _name = name;
            _principleAmount = princple;
            _duration = duration;
            _ratePolicy = ratePolicy;
        }

        public double SimpleInterest
        {

            get
            {


                return _principleAmount * _duration * _ratePolicy();

            }

        }


        public int Duration
        {

            get
            {
                return _duration;

            }
        }

        public double Principle
        {

            get
            {

                return _principleAmount;
            }
        }


        public int Accouno
        {

            get
            {

                return _accno;
            }
        }

        public string Name
        {

            get
            {
                return _name;

            }
        }
    }

}

