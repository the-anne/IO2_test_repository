using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWMiNI.TddWorkshop.CalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
            { return 0; }
            
            return Int32.Parse(numbers);
        }
    }
}
