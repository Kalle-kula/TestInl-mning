using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class2
    {
        public bool result;
        public void greaterNumber(int i1, int i2)
        {
            if (i1 > i2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
    }
}
