using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactoryCommonLib.Products
{
    public class AutomobileFacory
    {
        public IAutoMobile Make(AutoType msg)
        {

            if (msg == AutoType.AUDI)
                return new Audi();


            else if (msg == AutoType.TESLA)
                return new Tesla();

            return new Bmw();

        }
    }
}
