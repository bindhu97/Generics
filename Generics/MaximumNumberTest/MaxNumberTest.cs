using Generics.GenericMaximum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.MaximumNumberTest
{
    internal class MaxNumberTest
    {
        public void GivenIntegerValue_ReturnMaximum()
        {
            MaximumNumber maximum = new MaximumNumber();
            int data = maximum.MaxNumber(15, 20, 30);
            MaximumNumber.Equals(30, data);
        }
    }
}
